using DevExpress.Utils.DPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Winform_ToyProject.Services;

namespace Winform_ToyProject.Screens._3._PlayPiano
{
    public class Recorder
    {
        private const int MAX_TIME = 180000; // 3분

        private Stopwatch timer = new Stopwatch();

        private string title;
        private string data;

        public Recorder(string title)
        {
            this.title = title;
            data = string.Empty;
            timer.Start();
        }

        public void Add(string msg)
        {
            data += $"{timer.ElapsedMilliseconds} {msg}\n";
        }
        public void Stop()
        {
            timer.Stop();
            Save();
        }

        private void Save()
        {
            FileManagement.Instance.SaveRecord(title, data);
        }
    }
}
