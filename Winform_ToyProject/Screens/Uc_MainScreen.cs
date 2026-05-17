using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands;
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
    public partial class Uc_MainScreen : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_MainScreen()
        {
            InitializeComponent();
        }

        private void ChangePage(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            switch (btn.Name.Substring(4))
            {
                case "GamePlay": PageManagement.Instance.ChangePage(1); break;
                case "Rank": PageManagement.Instance.ChangePage(2); break;
                case "PlayPiano": PageManagement.Instance.ChangePage(3); break;
                case "Playback": PageManagement.Instance.ChangePage(4); break;
                case "Setting": PageManagement.Instance.ChangePage(5); break; 
                case "Exit": Application.Exit(); break;
            }
        }
    }
}
