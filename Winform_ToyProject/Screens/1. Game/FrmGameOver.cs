using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraMap.Drawing;
using DevExpress.XtraTreeList.Columns;
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
    public partial class FrmGameOver : DevExpress.XtraEditors.XtraForm
    {
        private FrmOverlay overlay;
        
        public FrmGameOver(int score)
        {
            InitializeComponent();
            lbl_Score.Text = $"SCORE : {score}";
        }

        public DialogResult ShowDialog(Form parent)
        {
            overlay = new FrmOverlay();
            overlay.ShowOverlay(parent);
            return base.ShowDialog(overlay);
        }

        private void btn_Retry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
            overlay.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MainForm.Instance.TabChange(0);

            this.Close();
            overlay.Close();
        }
    }
}