using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.SoundFont;
using MeltySynth;
using Winform_ToyProject.Service;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace Winform_ToyProject.Control
{
    public partial class Uc_Piano : DevExpress.XtraEditors.XtraUserControl
    {
        public event Action<Utils.Note>? TileClicked;

        public Uc_Piano()
        {
            InitializeComponent();
        }

        private void PianoTileClick(object sender, EventArgs e)
        {
            Utils.Note note = Utils.StringToNote((sender as SimpleButton).Name.Substring(6));
            
            SoundManagement.Instance.PlayNote(note);
            TileClicked?.Invoke(note);
        }
       
        private void HoverEffect(object sender, EventArgs e)
        {
            if (sender is not SimpleButton btn)
                return;

            //if (btn.BackColor == Color.White)
            //    btn.BackColor = Color.LightGray;
            //else if (btn.BackColor == Color.Black)
            //    btn.BackColor = Color.DarkGray;
        }
    }
}
