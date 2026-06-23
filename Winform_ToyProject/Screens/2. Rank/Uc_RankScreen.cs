using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform_ToyProject.Services;

namespace Winform_ToyProject.Screens
{
    public partial class Uc_RankScreen : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_RankScreen()
        {
            InitializeComponent();
            btn_PageBack.Click += (sender, e) => MainForm.Instance.TabChange(0);
        }
        private void Uc_RankScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LinkedList<Dictionary<string, string>> rankList = FileManagement.Instance.ReadRank();
                // 랭킹을 차트에 표시
                crt_Rank.Series[0].Points.Clear();
                foreach (var rank in rankList)
                {
                    string name = rank.Keys.First();
                    int score = int.Parse(rank.Values.First());
                    crt_Rank.Series[0].Points.AddPoint(name, score);
                }
            }
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {

        }
    }
}
