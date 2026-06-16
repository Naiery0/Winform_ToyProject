using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //특수문자를 제외한 글자를 없애버린다.
            string nameChecker = Regex.Replace(name, @"[ ^0-9a-zA-Z가-힣 ]{1,10}", "", RegexOptions.Singleline);
            //특수문자만 남게되었을 때, 그 길이가 0보다 크면 특수문자가 있다고 판단
            if (0 <nameChecker.Length )
            {
                lbl_Feedback.Text = "특수문자는 사용할 수 없습니다.";
                return false;
            }
            return true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (NamingCheck(tbx_Name.Text))
            {
                NameSet?.Invoke(tbx_Name.Text);
                overlay.Close();
                this.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm.Instance.TabChange(0);
            overlay.Close();
            this.Close();
        }
    }
}