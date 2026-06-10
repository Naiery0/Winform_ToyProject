using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Text;
using Winform_ToyProject.Control;
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
        public event Action<string>? ComentUpdated;
        public event Action<string>? ScoreUpdated;
        public event Action<int>? LivesUpdated;

        private CancellationTokenSource? gameCts;
        private CancellationTokenSource? answerCts;
        private GameStep gameStep = GameStep.Count;

        private int[] note = new int[2];
        private int score = 0;
        private int lives = 3;
        private int nowNote = 0;

        #region Game worker
        public async Task RunGameAsync()
        {
            while (true)
            {
                switch (gameStep)
                {
                    case GameStep.Count: await RunCountDownAsync(); break;
                    case GameStep.PlayNote: await RandomPlayNoteAsync(); break;
                    case GameStep.ChoiceAnswer: await ChoiceAnswerAsync(); break;
                    case GameStep.Done: await Done(); break;
                }

                if (gameCts.IsCancellationRequested)
                {
                    gameCts.Dispose();
                    gameStep = GameStep.Count;

                    gameCts = new CancellationTokenSource();
                    return;
                }
                

                if (gameStep == GameStep.Done)
                    gameStep = GameStep.Count; 
                else
                    gameStep++;

                if (lives <= 0)
                {
                    ComentUpdated?.Invoke("게임 오버!");
                    break;  
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
                    await Task.Delay(1000, gameCts.Token);
                }
            }
            catch (Exception)
            {}
        }

        // STEP 2. PlayNote
        private async Task RandomPlayNoteAsync()
        {
            ComentUpdated?.Invoke("Ding~");
            SoundManagement.Instance.OnMute(false);

            try
            {
                // 계이름, 옥타브
                note = SoundManagement.Instance.RandomPlayNote();
                SoundManagement.Instance.OnMute();
                await Task.Delay(1500, gameCts.Token); // 노트가 재생되는 동안 잠시 대기
            }
            catch (Exception)
            {}
        }

        // STEP 3. 정답 고를 때까지 기다리기
        private async Task ChoiceAnswerAsync()
        {
            answerCts = new CancellationTokenSource();
            ComentUpdated?.Invoke("정답은?");
            SoundManagement.Instance.OnMute(false);
            SoundManagement.Instance.TileClicked += OnTileClicked;
            
            Console.WriteLine(nowNote);

            try
            {
                int count = 5;
                while (count > 0)
                {
                    if (answerCts.IsCancellationRequested || gameCts.IsCancellationRequested)
                    {
                        answerCts.Dispose();
                        SoundManagement.Instance.TileClicked -= OnTileClicked;
                        return;
                    }
                    await Task.Delay(1000, answerCts.Token);
                    count--;
                }
            }
            catch (Exception)
            {}
        }

        // STEP 4. 점수 및 목숨 체크
        private async Task Done()
        {
            try
            {
                if (nowNote == note[0])
                {
                    score += 10;
                    ComentUpdated?.Invoke("정답!");
                    ScoreUpdated?.Invoke(score.ToString());
                }
                else
                {
                    lives--;
                    ComentUpdated?.Invoke("땡!");
                    LivesUpdated?.Invoke(lives);
                }
                await Task.Delay(2000, gameCts.Token); // 대기
            }
            catch (Exception)
            { }
        }
        #endregion

        private void OnTileClicked(Utils.Note note)
        {
            answerCts?.Cancel();
        }

        public void InitGame()
        {
            if (gameCts is null)
                gameCts = new CancellationTokenSource();
        }

        public void CancelGame()
        {
            try
            {
                gameCts?.Cancel();
                SoundManagement.Instance.OnMute(false);
            }
            catch (Exception)
            {}
        }
    }
}
