using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Winform_ToyProject.Screens
{
    public partial class Uc_GameScreen : XtraUserControl
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
        private CancellationTokenSource? cts; // 비동기 작업 취소

        public Uc_GameScreen()
        {
            InitializeComponent();
            TryInitScreen();
        }

        private bool TryInitScreen()
        {
            if (cts == null)
                cts = new CancellationTokenSource();

            if (cts.Token.IsCancellationRequested)
            {
                btn_GameStart.Visible = true;
                lbl_Coment.Text = "Coment";
                lbl_Coment.Visible = false;

                cts?.Dispose();
                cts = null;
                return true;
            }
            return false;
        }

        #region Game worker
        private async Task RunGameAsync()
        {
            while (true)
            {
                if (TryInitScreen())
                    return;

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
            lbl_Coment.Visible = true;
            for(int count = 3; count > 0; count--) 
            {
                lbl_Coment.Text = count.ToString();
                await Task.Delay(1000);

                if (TryInitScreen())
                    return;
            }
        }
        #endregion

        private async void btn_GameStart_Click(object sender, EventArgs e)
        {
            btn_GameStart.Visible = false;

            lbl_Test.Text = "Game Start!";
            gameStep = GameStep.Count;

            await RunCountDownAsync();

            lbl_Test.Text = "Count Down Finished!";
            gameStep = GameStep.PlayNote;
        }

        private void btn_PageBack_Click(object sender, EventArgs e)
        {
            PageManagement.Instance.ChangePage(0);
            cts?.Cancel();
        }

        /// **sequence**
        /// start
        /// timer
        /// play note
        /// chioce answer
        /// extra lifes
        /// difficulty up or done

    }
}
