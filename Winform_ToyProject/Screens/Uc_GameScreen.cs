using DevExpress.XtraEditors;
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
        private int count;

        public Uc_GameScreen()
        {
            InitializeComponent();
            btn_PageBack.Click += (sender, e) => PageManagement.Instance.ChangePage(0);
        }

        private async void btn_GameStart_Click(object sender, EventArgs e)
        {
            var task = Task.Run(() => GameStart());
            await task;
        }
        private void GameStart()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => GameStart()));
                return;
            }
            btn_GameStart.Visible = false;
            lbl_Coment.Visible = true;
            for (count = 3; count > 0; count--)
            {
                lbl_Coment.Text = count.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }
        }
    }
}
