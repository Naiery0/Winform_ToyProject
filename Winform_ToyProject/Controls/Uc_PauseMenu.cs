using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform_ToyProject.Controls;

namespace Winform_ToyProject.Screens._1._Game
{
    public partial class Uc_PauseMenu : DevExpress.XtraEditors.XtraUserControl
    {
        private string pageName;
        private FrmOverlay overlay;
        public Uc_PauseMenu(string pageName)
        {
            InitializeComponent();
            overlay = new FrmOverlay();
            overlay.ShowOverlay(MainForm.Instance);
            overlay.Controls.Add(this);
            this.Location = new Point((overlay.Width - this.Width) / 2, (overlay.Height - this.Height) / 2);
            this.pageName = pageName;
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            switch (this.pageName)
            {
                case "Game":
                    GameManagement.Instance.ResumeGame();
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
                    overlay.Close();
                    break;
            }
        }
    }
}
