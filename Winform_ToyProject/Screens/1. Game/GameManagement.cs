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
        public event EventHandler? AnswerWaited;

        private CancellationTokenSource? cts;
        private GameStep gameStep = GameStep.Count;

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

                if (cts.IsCancellationRequested)
                {
                    cts.Dispose();
                    gameStep = GameStep.Count;

                    cts = new CancellationTokenSource();
                    return;
                }
                

                if (gameStep == GameStep.Done)
                    gameStep = GameStep.Count; 
                else
                    gameStep++;
            }
        }

        // STEP 1. Play Note 전 타이머
        private async Task RunCountDownAsync()
        {
            try
            {
                for (int count = 3; count > 0; count--)
                {
                    if (cts.IsCancellationRequested)
                        return;

                    ComentUpdated?.Invoke(count.ToString());
                    await Task.Delay(1000, cts.Token);
                }
            }
            catch (Exception)
            {}
        }

        // STEP 2. PlayNote
        private async Task RandomPlayNoteAsync()
        {
            try
            {
                ComentUpdated?.Invoke("Ding~");
                SoundManagement.Instance.RandomPlayNote();
                await Task.Delay(1500, cts.Token); // 노트가 재생되는 동안 잠시 대기
            }
            catch (Exception)
            {}
        }

        // STEP 3. 정답 고를 때까지 기다리기
        private async Task ChoiceAnswerAsync()
        {
            try
            {
                ComentUpdated?.Invoke("정답은?");
                await Task.Delay(1500, cts.Token); // 임의 대기
            }
            catch (Exception)
            {}
        }

        // STEP 4. 점수 및 목숨 체크
        private async Task Done()
        {
            try
            {
                ComentUpdated?.Invoke("Done...");
                await Task.Delay(1500, cts.Token); // 임의 대기
            }
            catch (Exception)
            {}
        }

        private void OnTileClicked()
        {

        }

        #endregion
        public void InitGame()
        {
            if (cts is null)
                cts = new CancellationTokenSource();
        }

        public void CancelGame()
        {
            try
            {
                cts?.Cancel();
            }
            catch (Exception)
            {}
        }
    }
}
