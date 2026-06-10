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
        private Panel[] LivesArr;

        public Uc_GameScreen()
        {
            InitializeComponent();
            LivesArr = new Panel[] { pnl_Heart1, pnl_Heart2, pnl_Heart3 };
            GameManagement.Instance.ComentUpdated += Session_TimerUpdated;
            GameManagement.Instance.LivesUpdated += OnUpdateLives;
            GameManagement.Instance.ScoreUpdated += OnUpdateScore;
        }

        private void InitializeScreen()
        {
            GameManagement.Instance.InitGame();

            btn_GameStart.Visible = true;
            lbl_Coment.Visible = false;
        }

        private void Session_TimerUpdated(string obj)
        {
            lbl_Coment.Text = $"{obj}";
        }

        private async void btn_GameStart_Click(object sender, EventArgs e)
        {
            btn_GameStart.Visible = false;
            lbl_Coment.Visible = true;

            await GameManagement.Instance.RunGameAsync();
        }

        private void btn_PageBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.TabChange(0);
            GameManagement.Instance.CancelGame();
        }

        private void Uc_GameScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                InitializeScreen();
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
            // TODO: 일시정지 기능 구현
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

