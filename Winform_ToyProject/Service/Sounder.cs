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
    public class Sounder
    {
        private const string PATH = @"Sound\Essential Keys-sforzando-v9.6.sf2";
        private Synthesizer synthesizer; // MeltySynth
        private SynthesizerSettings synthesizerSettings;
        private WaveOutEvent waveOut; // NAudio

        public Sounder()
        {
            synthesizerSettings = new SynthesizerSettings(44100)
            {
                MaximumPolyphony = 64 // 최대 동시 발음 수
            };
            synthesizer = new Synthesizer(Path.GetFullPath(PATH), synthesizerSettings);
            waveOut = new WaveOutEvent();

            waveOut.Init(new MeltySynthProvider(synthesizer, new object()));
            waveOut.Play();
        }

        public void PlayNote(string str)
        {
            Console.WriteLine(str);
            switch (str)
            {
                case "C": synthesizer.NoteOn(0, 60, 100);
                    break;
                case "Cs": synthesizer.NoteOn(0, 61, 100);
                    break;
                case "D": synthesizer.NoteOn(0, 62, 100);
                    break;
                case "Ds": synthesizer.NoteOn(0, 63, 100);
                    break;
                case "E": synthesizer.NoteOn(0, 64, 100);
                    break;
                case "F": synthesizer.NoteOn(0, 65, 100);
                    break;
                case "Fs": synthesizer.NoteOn(0, 66, 100);
                    break;
                case "G": synthesizer.NoteOn(0, 67, 100);
                    break;
                case "Gs": synthesizer.NoteOn(0, 68, 100);
                    break;
                case "A": synthesizer.NoteOn(0, 69, 100);
                    break;
                case "As": synthesizer.NoteOn(0, 70, 100);
                    break;
                case "B": synthesizer.NoteOn(0, 71, 100);
                    break;
            }
        }

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
