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
                case "GamePlay": MainForm.Instance.TabChange(1); break;
                case "Rank": MainForm.Instance.TabChange(2); break;
                case "PlayPiano": MainForm.Instance.TabChange(3); break;
                case "Playback": MainForm.Instance.TabChange(4); break;
                case "Setting": MainForm.Instance.TabChange(5); break; 
                case "Exit": Application.Exit(); break;
            }
        }
    }
}
