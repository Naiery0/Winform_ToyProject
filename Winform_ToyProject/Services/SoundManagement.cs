using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.RichEdit.Export;
using MeltySynth;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text;

namespace Winform_ToyProject.Service
{
    public class SoundManagement
    {
        #region instance
        private static SoundManagement? instance;
        public static SoundManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new SoundManagement();

                return instance;
            }
        }   
        #endregion

        private const string PATH = @"C:\Users\isac276\Desktop\Sound\Essential Keys-sforzando-v9.6.sf2";
        private Synthesizer synthesizer; // MeltySynth
        private SynthesizerSettings synthesizerSettings;
        private WaveOutEvent waveOut; // NAudio

        protected SoundManagement()
        {
            synthesizerSettings = new SynthesizerSettings(44100)
            {
                MaximumPolyphony = 64 // 최대 동시 발음 수
            };
            synthesizer = new Synthesizer(PATH, synthesizerSettings);
            waveOut = new WaveOutEvent();

            waveOut.Init(new MeltySynthProvider(synthesizer, new object()));
            waveOut.Play();
        }

        /// <summary>
        /// NoteOn(channel, noteNumber, velocity)
        /// channel: 악기?? 뭐임 이거
        /// noteNumber: 음 높이 
        /// velocity: 음 세기 (0~127)
        /// 피아노의 경우 (A0~C8) => (21~108)
        /// </summary>
        public void PlayNote(Utils.Note note, int octave = 4)
        {
            int key = 12 * (octave + 1) + (int)note;
            synthesizer.NoteOn(0, key, 100);
        }

        //public int NotetoKey(Utils.Note note, int octave = 4)
        //{
        //    return 12 * (octave + 1) + (int)note;
        //}

        //public void PickPreset(string str)
        //{
        //    synthesizer.ProcessMidiMessage(0, 0xC0, 0, 0); // PC 000 Yamaha C5 Grand 
        //}

        public void Close()
        {
            waveOut?.Stop();
            waveOut?.Dispose();
        }
    }
}
