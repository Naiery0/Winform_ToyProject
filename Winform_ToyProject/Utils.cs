using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject
{
    public static class Utils
    {


        // 음계
        public enum Note
        {
            C, Cs, D, Ds, E, F, Fs, G, Gs, A, As, B, None
        }

        public enum Command
        {
            // 한 칸씩 컨트롤
            OctaveUp, OctaveDown, 
            VolumeUp, VolumeDown, 

            Record, RecordEnd, 

            None
        }

        public static Note StringToNote(string str)
        {
            if(Enum.TryParse(str, out Note result) && Enum.IsDefined(typeof(Note), result))
                return result;

            else
                return Note.None;
        }

        public static void Pause ()
        {
           
        }
    }
}
