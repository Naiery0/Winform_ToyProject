using System;
using System.Collections.Generic;
using System.Text;
using Winform_ToyProject.Service;

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
        
        // game 취소
        public CancellationTokenSource? cts;

        public event Action<string>? ComentUpdated;
        public event Action<string>? NotePlayed;


        #region Game worker
        public async Task RunGameAsync()
        {
            if (cts is null)
                cts = new CancellationTokenSource();

            await RunCountDownAsync();
            gameStep = GameStep.PlayNote;

            while (true)
            {
                switch (gameStep)
                {
                    case GameStep.Count: await RunCountDownAsync(); break;
                    case GameStep.PlayNote: RandomPlayNote(); break; 
                    case GameStep.ChoiceAnswer: break;
                    case GameStep.ExtraLifes: break;
                    case GameStep.Done: break;
                }
                await Task.Delay(100); // 게임 루프 간격 조절
            }
        }

        // 0. 시작 Count
        // STEP 1. Play Note 전 타이머
        private async Task RunCountDownAsync()
        {
            for (int count = 3; count > 0; count--)
            {
                // 메인화면으로 갔으면 타이머 취소
                if (cts.IsCancellationRequested)
                {
                    cts = null;
                    return;
                }

                ComentUpdated?.Invoke(count.ToString());
                await Task.Delay(1000);
            }
        }

        // 2. PlayNote
        private void RandomPlayNote()
        {
            Random random = new Random();
            int randNum = random.Next() % 12;
            int randOctave = random.Next() % 3 + 4; // 4, 5, 6 옥타브 중 랜덤 선택

            SoundManagement.Instance.PlayNote((Utils.Note)randNum, randOctave);
            ComentUpdated?.Invoke("♪");

            gameStep = GameStep.ChoiceAnswer;
        }
        #endregion
    }
}
