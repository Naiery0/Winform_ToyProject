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
    public partial class Uc_PlayPianoScreen : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_PlayPianoScreen()
        {
            InitializeComponent();
            btn_PageBack.Click += (sender, e) => PageManagement.Instance.ChangePage(0);
        }
    }
}
