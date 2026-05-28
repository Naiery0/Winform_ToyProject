using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Screens
{
    public class GameSession
    {
        private enum GameStep
        {
            Idle,
            Count,
            PlayNote,
            ChoiceAnswer,
            ExtraLifes,
            Done
        }
        private GameStep gameStep = GameStep.Idle;
        public event Action<string>? TimerUpdated;


        #region Game worker
        private async Task RunGameAsync()
        {
            while (true)
            {
                switch (gameStep)
                {
                    case GameStep.Count:
                        // Count 관련 작업
                        break;
                    case GameStep.PlayNote:
                        // Play Note 관련 작업
                        break;
                    case GameStep.ChoiceAnswer:
                        // Choice Answer 관련 작업
                        break;
                    case GameStep.ExtraLifes:
                        // Extra Lifes 관련 작업
                        break;
                    case GameStep.Done:
                        // Done 관련 작업
                        break;
                }
                await Task.Delay(100); // 게임 루프 간격 조절
            }
        }
        private async Task RunCountDownAsync()
        {
            TimerUpdated?.Invoke("3");
            for (int count = 3; count > 0; count--)
            {
                await Task.Delay(1000);
                TimerUpdated?.Invoke(count.ToString());
            }
        }
        #endregion
    }
}
