using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform_ToyProject.Screens;

namespace Winform_ToyProject.Controls
{
    public partial class FrmPauseMenu : DevExpress.XtraEditors.XtraForm
    {
        private string pageName = "";
        private FrmOverlay overlay;

        public FrmPauseMenu(string pageName)
        {
            InitializeComponent();
            overlay = new FrmOverlay();
            overlay.ShowOverlay(MainForm.Instance);

            this.StartPosition = FormStartPosition.CenterParent;
            this.pageName = pageName;
            this.TransparencyKey = Color.Black;
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            switch (this.pageName)
            {
                case "Game":
                    GameManagement.Instance.ResumeGame();
                    this.Close();
                    overlay.Close();
                    break;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            switch (this.pageName)
            {
                case "Game":
                    GameManagement.Instance.CancelGame();
                    MainForm.Instance.TabChange(0);
                    this.Close();
                    overlay.Close();
                    break;
            }
        }
    }
}