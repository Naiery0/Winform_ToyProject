using DevExpress.XtraDashboardLayout;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Winform_ToyProject.Controls
{
    public partial class FrmOverlay : DevExpress.XtraEditors.XtraForm
    {
        public FrmOverlay()
        {
            InitializeComponent();
        }

        public void ShowOverlay(Form parent)
        {
            // 부모 폼의 크기만큼
            Size = parent.ClientSize;
            Location = parent.PointToScreen(Point.Empty);
            base.Show();
        }
    }
}