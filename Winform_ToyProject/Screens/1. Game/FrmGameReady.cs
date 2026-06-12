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
    public partial class FrmGameReady : DevExpress.XtraEditors.XtraForm
    {
        public event Action<string>? NameSet;

        private FrmOverlay overlay;

        public FrmGameReady()
        {
            InitializeComponent();
        }

        public string ShowDialog(Form parent)
        {
            overlay = new FrmOverlay();
            overlay.ShowOverlay(parent);
            base.ShowDialog(overlay);

            return tbx_Name.Text;
        }

        private bool NamingCheck(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                lbl_Feedback.Text = "이름을 입력해주세요.";
                return false;
            }

            return true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (NamingCheck(tbx_Name.Text))
            {
                NameSet?.Invoke(tbx_Name.Text);
                this.Close();
                overlay.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm.Instance.TabChange(0);
            this.Close();
            overlay.Close();
        }
    }
}