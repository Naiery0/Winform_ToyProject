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

        public static Note StringToNote(string str)
        {
            if(Enum.TryParse(str, out Note result) && Enum.IsDefined(typeof(Note), result))
                return result;

            else
                return Note.None;
        }
    }
}
