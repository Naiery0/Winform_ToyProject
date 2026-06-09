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
        public CancellationTokenSource? cts;

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
                    //case GameStep.ExtraLifes: break;
                    case GameStep.Done: break;
                }

                await Task.Delay(100); // 게임 루프 간격 조절
            }
        }

        // STEP 1. Play Note 전 타이머
        private async Task RunCountDownAsync()
        {
            for (int count = 3; count > 0; count--)
            {
                if (gameStep != GameStep.Count)
                    return;

                ComentUpdated?.Invoke(count.ToString());
                await Task.Delay(1000);
            }

            gameStep = GameStep.PlayNote;
        }

        // TODO: 카운트 이후 취소로직 미구현
        // STEP 2. PlayNote
        private async Task RandomPlayNoteAsync()
        {
            SoundManagement.Instance.RandomPlayNote();
            ComentUpdated?.Invoke("Ding~");
            await Task.Delay(1500); // 노트가 재생되는 동안 잠시 대기

            gameStep = GameStep.ChoiceAnswer;
        }

        // STEP 3. 정답 고를 때까지 기다리기
        private async Task ChoiceAnswerAsync()
        {
            ComentUpdated?.Invoke("정답은?");
        }

        private void OnTileClicked()
        {

        }

        #endregion

        public void StepReset()
        {
            gameStep = GameStep.Count;
        }
    }
}
