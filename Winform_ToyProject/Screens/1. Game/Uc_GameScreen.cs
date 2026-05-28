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
        GameSession session;
        public Uc_GameScreen()
        {
            InitializeComponent();
        }

        private void InitializeScreen()
        {
            session = new GameSession();
            session.TimerUpdated += Session_TimerUpdated;

            btn_GameStart.Visible = true;
            lbl_Coment.Visible = false;
            lbl_Test.Text = "Game Start!";
        }

        private void Session_TimerUpdated(string obj)
        {
            lbl_Coment.Text = $"{obj}";
        }

        private async void btn_GameStart_Click(object sender, EventArgs e)
        {
            btn_GameStart.Visible = false;
            lbl_Coment.Visible = true;
            lbl_Test.Text = "Game Start!";
            await session.RunCountDownAsync();
            lbl_Test.Text = "Count Down Finished!";
        }

        private void btn_PageBack_Click(object sender, EventArgs e) => MainForm.Instance.TabChange(0);


        /// **sequence**
        /// start
        /// timer
        /// play note
        /// chioce answer
        /// extra lifes
        /// difficulty up or done

    }
}

