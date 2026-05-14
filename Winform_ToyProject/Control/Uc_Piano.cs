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

namespace Winform_ToyProject.Control
{
    public partial class Uc_Piano : DevExpress.XtraEditors.XtraUserControl
    {
        Sounder sounder;
        private const string PATH = @"Sound\Essential Keys-sforzando-v9.6.sf2";
        public Uc_Piano()
        {
            sounder = new Sounder();
            InitializeComponent();

            var sf = new NAudio.SoundFont.SoundFont(Path.GetFullPath(PATH));
            Console.WriteLine(sf);
            //foreach (var preset in sf.Presets)
            //{
            //    Console.WriteLine($"Bank {preset.BankNumber}, Preset {preset.PatchNumber}: {preset.Name}");
            //}
        }

        private void PianoTileClick(Object sender, EventArgs e)
        {
            sounder.PlayNote((sender as SimpleButton).Name.Substring(6));
        }
    }
}
