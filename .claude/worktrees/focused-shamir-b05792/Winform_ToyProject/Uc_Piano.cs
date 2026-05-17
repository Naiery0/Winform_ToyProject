using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace Winform_ToyProject
{
    public partial class Uc_Piano : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_Piano()
        {
            InitializeComponent();
            //NAudio.SoundFont.SoundFont sf = new NAudio.SoundFont.SoundFont("../../Sound_Resource/Essential Keys-sforzando-v9.6.sf2");

            //Console.WriteLine(sf);
        }

        private void PianoTileClick(Object sender, EventArgs e)
        {
            switch((sender as SimpleButton).Name.Substring(6))
            {
                case "C":
                    break;
                case "Cs":
                    break;
                case "D":
                    break;
                case "Ds":
                    break;
                case "E":
                    break;
                case "F":
                    break;
                case "Fs":
                    break;
                case "G":
                    break;
                case "Gs":
                    break;
                case "A":
                    break;
                case "As":
                    break;
                case "B":
                    break;
            }
        }
    }
}
