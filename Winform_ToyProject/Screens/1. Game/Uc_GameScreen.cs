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
using Winform_ToyProject.Controls;
using Winform_ToyProject.Screens._1._Game;

namespace Winform_ToyProject.Screens
{
    public partial class Uc_GameScreen : XtraUserControl
    {
        private Panel[] LivesArr;

        public Uc_GameScreen()
        {
            InitializeComponent();
            LivesArr = new Panel[] { pnl_Heart1, pnl_Heart2, pnl_Heart3 };
            GameManagement.Instance.ComentUpdated += Session_TimerUpdated;
            GameManagement.Instance.NameUpdated += OnUpdateName;
            GameManagement.Instance.LivesUpdated += OnUpdateLives;
            GameManagement.Instance.ScoreUpdated += OnUpdateScore;
            GameManagement.Instance.TimerUpdated += OnUpdateProgressBar;
        }

        private void OnUpdateProgressBar(int timer)
        {
            pgb_Timer.EditValue = timer;
        }

        private void Session_TimerUpdated(string count)
        { 
            lbl_Coment.Text = $"{count}";
        }

        private async void btn_GameStart_Click(object sender, EventArgs e)
        {
            btn_GameStart.Visible = false;
            lbl_Coment.Visible = true;
            pgb_Timer.Visible = true;

            await GameManagement.Instance.RunGameAsync();
        }


        private void Uc_GameScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                FrmGameReady gameReady = new FrmGameReady();
                GameManagement.Instance.InitGame(gameReady.ShowDialog(MainForm.Instance));

                btn_GameStart.Visible = true;
                lbl_Coment.Visible = false;
                pgb_Timer.Visible = false;
            }
        }

        private void OnUpdateName(string name)
        {
            lbl_Name.Text = $"Name : {name}";
        }

        private void OnUpdateLives(int lives)
        {
            for (int i = 0; i < LivesArr.Length; i++)
            {
                LivesArr[i].Visible = i < lives;
            }
        }

        private void OnUpdateScore(string score)
        {
            lbl_Score.Text = $"SCORE : {score}";
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            // 일시정지 기능 구현...은 좀 어려울지도... 됐네?
            GameManagement.Instance.PauseGame();
            FrmPauseMenu pauseForm = new FrmPauseMenu("Game");
            pauseForm.ShowDialog();
        }

        private void btn_PageBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.TabChange(0);
            GameManagement.Instance.CancelGame();
        }
    }
}

