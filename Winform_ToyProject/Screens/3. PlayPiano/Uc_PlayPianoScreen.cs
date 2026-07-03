using DevExpress.Utils.DPI;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform_ToyProject.Screens._3._PlayPiano;
using Winform_ToyProject.Service;

namespace Winform_ToyProject.Screens
{
    public partial class Uc_PlayPianoScreen : DevExpress.XtraEditors.XtraUserControl
    {
        private const int MIN_OCTAVE = 1;
        private const int MAX_OCTAVE = 7;
        private const int MIN_VOLUME = 0;
        private const int MAX_VOLUME = 127;

        private readonly Dictionary<Keys, (Utils.Note note, int octave)> keyMap = new();
        private readonly Dictionary<Keys, Utils.Command> commandMap = new();
        private readonly HashSet<Keys> pressedKeys = new();

        private int octave = 4;
        private int velocity;
        private bool isRecording = false;

        private Recorder? recorder = null;

        public Uc_PlayPianoScreen()
        {
            InitializeComponent();

            btn_PageBack.Click += (sender, e) => MainForm.Instance.TabChange(0);

            // 키 입력 받기 위해 포커스 유지
            this.TabStop = true;
            this.Load += (_, __) => this.Focus();
            this.Click += (_, __) => this.Focus();
            this.MouseDown += (_, __) => this.Focus();
            uc_Piano1.MouseDown += (_, __) => this.Focus();

            InitPiano();
        }
        private void InitPiano()
        {
            BuildKeyMap();
            velocity = SoundManagement.Instance.Volume;
            octave = 4;
            tbc_Volume.Value = velocity;
            tbc_Octave.Value = octave;
        }

        private void BuildKeyMap()
        {
            keyMap.Clear();

            // whiteNote1 = zxcvbnm,
            keyMap[Keys.Z] = (Utils.Note.C, octave);
            keyMap[Keys.X] = (Utils.Note.D, octave);
            keyMap[Keys.C] = (Utils.Note.E, octave);
            keyMap[Keys.V] = (Utils.Note.F, octave);
            keyMap[Keys.B] = (Utils.Note.G, octave);
            keyMap[Keys.N] = (Utils.Note.A, octave);
            keyMap[Keys.M] = (Utils.Note.B, octave);
            keyMap[Keys.Oemcomma] = (Utils.Note.C, octave + 1);

            // blackNote1 = sdghj
            keyMap[Keys.S] = (Utils.Note.Cs, octave);
            keyMap[Keys.D] = (Utils.Note.Ds, octave);
            keyMap[Keys.G] = (Utils.Note.Fs, octave);
            keyMap[Keys.H] = (Utils.Note.Gs, octave);
            keyMap[Keys.J] = (Utils.Note.As, octave);

            // whiteNote2 = qwertyui
            keyMap[Keys.Q] = (Utils.Note.C, octave + 1);
            keyMap[Keys.W] = (Utils.Note.D, octave + 1);
            keyMap[Keys.E] = (Utils.Note.E, octave + 1);
            keyMap[Keys.R] = (Utils.Note.F, octave + 1);
            keyMap[Keys.T] = (Utils.Note.G, octave + 1);
            keyMap[Keys.Y] = (Utils.Note.A, octave + 1);
            keyMap[Keys.U] = (Utils.Note.B, octave + 1);
            keyMap[Keys.I] = (Utils.Note.C, octave + 2);

            // blackNote2 = 23567
            keyMap[Keys.D2] = (Utils.Note.Cs, octave + 1);
            keyMap[Keys.D3] = (Utils.Note.Ds, octave + 1);
            keyMap[Keys.D5] = (Utils.Note.Fs, octave + 1);
            keyMap[Keys.D6] = (Utils.Note.Gs, octave + 1);
            keyMap[Keys.D7] = (Utils.Note.As, octave + 1);

            //commandMap[Keys.OemMinus] = (Utils.Command.VolumeDown, string.Empty);
            //commandMap[Keys.Oemplus] = (Utils.Command.VolumeUp, string.Empty);
            //commandMap[Keys.OemOpenBrackets] = (Utils.Command.OctaveDown, string.Empty);
            //commandMap[Keys.OemCloseBrackets] = (Utils.Command.OctaveUp, string.Empty);

            commandMap[Keys.OemMinus] = Utils.Command.VolumeDown;
            commandMap[Keys.Oemplus] = Utils.Command.VolumeUp;
            commandMap[Keys.OemOpenBrackets] = Utils.Command.OctaveDown;
            commandMap[Keys.OemCloseBrackets] = Utils.Command.OctaveUp;
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            const int KEYDOWN = 0x0100;
            const int KEYUP = 0x0101;
            const int SYSKEYDOWN = 0x0104;
            const int SYSKEYUP = 0x0105;

            Keys keyData = (Keys)(int)m.WParam;
            KeyEventArgs e = new KeyEventArgs(keyData);

            if (m.Msg == KEYDOWN || m.Msg == SYSKEYDOWN)
            {
                Uc_PlayPianoScreen_KeyDown(this, e);
                if (e.Handled)
                    return true;
            }
            else if (m.Msg == KEYUP || m.Msg == SYSKEYUP)
            {
                Uc_PlayPianoScreen_KeyUp(this, e);
                if (e.Handled)
                    return true;
            }

            return base.ProcessKeyPreview(ref m);
        }

        private void Uc_PlayPianoScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (commandMap.TryGetValue(e.KeyCode, out var command))
            {
                ExecuteCommand(command);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (!keyMap.TryGetValue(e.KeyCode, out var mapped))
                return;

            if (!pressedKeys.Add(e.KeyCode))
                return; // 키 반복 입력 방지

            SoundManagement.Instance.PlayNote(mapped.note, mapped.octave, velocity);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void Uc_PlayPianoScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (!keyMap.TryGetValue(e.KeyCode, out var mapped))
                return;

            if (!pressedKeys.Remove(e.KeyCode))
                return;

            SoundManagement.Instance.StopNote(mapped.note, mapped.octave);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void ExecuteCommand(Utils.Command command)
        {
            switch (command)
            {
                case Utils.Command.OctaveUp:
                    if (octave < MAX_OCTAVE)
                    {
                        octave++;
                        BuildKeyMap();
                        tbc_Octave.Value = octave;
                    }
                    break;
                case Utils.Command.OctaveDown:
                    if (octave > MIN_OCTAVE)
                    {
                        octave--;
                        BuildKeyMap();
                        tbc_Octave.Value = octave;
                    }
                    break;
                case Utils.Command.VolumeUp:
                    if (velocity < MAX_VOLUME)
                    {
                        velocity++;
                        tbc_Volume.Value = velocity;
                    }
                    break;
                case Utils.Command.VolumeDown:
                    if (velocity > MIN_VOLUME)
                    {
                        velocity--;
                        tbc_Volume.Value = velocity;
                    }
                    break;
            }
        }

        private void tbc_Volume_ValueChanged(object sender, EventArgs e)
        {
            velocity = tbc_Volume.Value;
        }

        private void tbc_Octave_ValueChanged(object sender, EventArgs e)
        {
            this.octave = tbc_Octave.Value;
            BuildKeyMap();
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            if (isRecording)
                RecordStart();
            else
                RecordStop();
        }

        private void RecordStop()
        {
            recorder?.Stop();
            recorder = null;    
            isRecording = false;
            btn_Record.Text = "Record ●";
            btn_Record.BackColor = Color.White;
        }

        private void RecordStart()
        {
            isRecording = true;
            btn_Record.Text = "Stop ■";
            btn_Record.BackColor = Color.LightGray;
        }

        private void OpenTitleDialog()
        {
            string title = string.Empty;


            recorder = new Recorder($"{title}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}");
        }
    }
}