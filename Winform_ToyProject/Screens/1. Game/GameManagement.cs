using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Winform_ToyProject.Control;
using Winform_ToyProject.Screens._1._Game;
using Winform_ToyProject.Service;

namespace Winform_ToyProject.Screens
{
    public class GameManagement
    {
        #region instance
        private static GameManagement? instance;
        public static GameManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new GameManagement();

                return instance;
            }
        }
        #endregion
        private enum GameStep
        {
            Count,
            PlayNote,
            ChoiceAnswer,
            ExtraLifes,
            Done
        }
        public event Action<string>? NameUpdated;
        public event Action<string>? ComentUpdated;
        public event Action<string>? ScoreUpdated;
        public event Action<int>? LivesUpdated;

        private CancellationTokenSource? gameCts;
        private CancellationTokenSource? answerCts;
        // set(): Resume, Reset(): Pause
        private ManualResetEventSlim pauseEvent = new ManualResetEventSlim(true);
        private GameStep gameStep = GameStep.Count;

        private int[] quizNote = new int[2];
        private int clickedNote;

        private UserModel? model;
        
        // 원활한 테스트를 위한 수작 (default: 0)
        private int devTimer = 100;

        #region Game worker
        public async Task RunGameAsync()
        {
            // TODO: 게임이 취소되기 전에 새게임을 시작하면 버그 발생함
            gameCts = new CancellationTokenSource();
            while (true)
            {
                switch (gameStep)
                {
                    case GameStep.Count: await RunCountDownAsync(); break;
                    case GameStep.PlayNote: await RandomPlayNoteAsync(); break;
                    case GameStep.ChoiceAnswer: 
                        await ChoiceAnswerAsync(); 
                        answerCts?.Dispose();
                        SoundManagement.Instance.TileClicked -= OnTileClicked; 
                        break;
                    case GameStep.Done: await Done(); break;
                }

                if (gameStep == GameStep.Done)
                    gameStep = GameStep.Count;
                else
                    gameStep++;

                if (gameCts.IsCancellationRequested)
                {
                    Debug.WriteLine("게임 취소");
                    return;
                }

                if (model.Lives <= 0)
                {
                    FrmGameOver frmGameOver = new FrmGameOver(model.Score);
                    
                    if (frmGameOver.ShowDialog(MainForm.Instance) == DialogResult.OK)
                        InitGame(model.Name);
                    else
                        return;
                }
            }
        }

        // STEP 1. Play Note 전 타이머
        private async Task RunCountDownAsync()
        {
            SoundManagement.Instance.OnMute();

            try
            {
                for (int count = 3; count > 0; count--)
                {
                    if (gameCts.IsCancellationRequested)
                        return;

                    ComentUpdated?.Invoke(count.ToString());

                    await TaskWaitAsync(1000 / devTimer, gameCts);
                }
            }
            catch (Exception)
            {
            }
        }

        // STEP 2. PlayNote
        private async Task RandomPlayNoteAsync()
        {
            ComentUpdated?.Invoke("Ding~");
            SoundManagement.Instance.OffMute();

            try
            {
                // 계이름, 옥타브
                quizNote = SoundManagement.Instance.RandomPlayNote();
                SoundManagement.Instance.OnMute();
                
                Debug.WriteLine($"quizNote: {quizNote[0]}, Octave: {quizNote[1]}");

                await TaskWaitAsync(1500 / devTimer, gameCts);
            }
            catch (Exception)
            {
            }
        }

        // STEP 3. 정답 고를 때까지 기다리기
        private async Task ChoiceAnswerAsync()
        {
            answerCts = new CancellationTokenSource();
            
            ComentUpdated?.Invoke("정답은?");
            SoundManagement.Instance.OffMute();
            SoundManagement.Instance.TileClicked += OnTileClicked;

            try
            {
                int count = 5;
                while (count > 0)
                {
                    if (answerCts.IsCancellationRequested || gameCts.IsCancellationRequested)
                        break;

                    count--;
                    await TaskWaitAsync(1000, answerCts);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        // STEP 4. 정답 체크
        private async Task Done()
        {
            try
            {
                if (clickedNote == quizNote[0])
                {
                    model.Score += 10;
                    ComentUpdated?.Invoke("정답!");
                    ScoreUpdated?.Invoke(model.Score.ToString());
                }
                else
                {
                    model.Lives--;
                    ComentUpdated?.Invoke("땡!");
                    LivesUpdated?.Invoke(model.Lives);
                }

                await TaskWaitAsync(2000 / devTimer, gameCts);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Pause 기능을 만들기 위해 생기게 된 메서드
        /// </summary>
        /// <param name="time">딜레이 시간</param>
        /// <param name="cts">사용할 취소 토큰</param>
        /// <returns></returns>
        private async Task TaskWaitAsync(int time, CancellationTokenSource cts)
        {
            int i = 0;
            while (i < time)
            {
                await Task.Delay(1, cts.Token);
                i++;
                
                await Task.Run(() => pauseEvent.Wait()); // 그냥 Wait 쓰면 프로그램이 멈춤
            }
        }

        private void OnTileClicked(Utils.Note note)
        {
            clickedNote = (int)note;
            answerCts?.Cancel();
        }
        #endregion

        #region public methods
        public void PauseGame() => pauseEvent.Reset();
        public void ResumeGame() => pauseEvent.Set();

        public void InitGame(string name)
        {
            gameCts?.Dispose();
            gameStep = GameStep.Count;
            model = new UserModel(name);

            // UI 초기화
            NameUpdated?.Invoke(model.Name);
            ScoreUpdated?.Invoke(model.Score.ToString());
            LivesUpdated?.Invoke(model.Lives);
        }

        public void CancelGame()
        {
            try
            {
                gameCts?.Cancel();
                SoundManagement.Instance.OffMute();

                // UI 초기화
                NameUpdated?.Invoke("");
                ScoreUpdated?.Invoke("0");
                LivesUpdated?.Invoke(3);
            }
            catch (Exception)
            {}
        }
        #endregion
    }
}
