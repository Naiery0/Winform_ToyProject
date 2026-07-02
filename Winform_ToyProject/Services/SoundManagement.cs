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
    // 얘도 사용할 곳마다 클래스를 새로 만드는 게 맞지 않았을까?
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

        private bool isMute = false;
        private int velocity = 100; // 음 세기 (0~127)

        public int Volume { get => velocity; set => SetVelocity(value);}
        public event Action<Utils.Note>? TileClicked;

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
        private void SetVelocity(int velocity) => this.velocity = Math.Clamp(velocity, 0, 127);


        /// <summary>
        /// NoteOn(channel, noteNumber, velocity)
        /// channel: 악기?? 뭐임 이거
        /// noteNumber: 음 높이 
        /// velocity: 음 세기 (0~127)
        /// 피아노의 경우 (A0~C8) => (21~108)
        /// </summary>
        public void ClickNote(Utils.Note note, int octave = 4)
        {
            if (isMute)
                return;
            PlayNote(note, octave);
            TileClicked?.Invoke(note);
        }

        public void PlayNote(Utils.Note note, int octave = 4, int velocity = -1)
        {
            if (isMute)
                return;

            if (velocity == -1)
                velocity = this.velocity;

            int key = 12 * (octave + 1) + (int)note;
            synthesizer.NoteOn(0, key, velocity);
        }
        public void StopNote(Utils.Note note, int octave = 4)
        {
            int key = 12 * (octave + 1) + (int)note;
            synthesizer.NoteOff(0, key);
        }

        public void VolumeUp() => SetVelocity(++velocity);
        public void VolumeDown() => SetVelocity(--velocity);

        public void OnMute() => this.isMute = true;
        public void OffMute() => this.isMute = false;


        //public int NotetoKey(Utils.Note note, int octave = 4)
        //{
        //    return 12 * (octave + 1) + (int)note;
        //}

        //public void PickPreset(string str)
        //{
        //    synthesizer.ProcessMidiMessage(0, 0xC0, 0, 0); // PC 000 Yamaha C5 Grand 
        //}

        public int[] RandomPlayNote()
        {
            Random random = new Random();
            int randNum = random.Next() % 12;
            int randOctave = random.Next() % 3 + 4; // 4, 5, 6 옥타브 중 랜덤 선택
            PlayNote((Utils.Note)randNum, randOctave);

            return new int[] { randNum, randOctave };
        }

        public void Close()
        {
            waveOut?.Stop();
            waveOut?.Dispose();
        }
    }
}
