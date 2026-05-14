using DevExpress.XtraRichEdit.Import.Doc;
using MeltySynth;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Service
{
    public class MeltySynthProvider : ISampleProvider
    {
        private Synthesizer synthesizer;
        private WaveFormat waveFormat;
        private object synLock;
        private float[] leftBuffer = Array.Empty<float>();
        private float[] rightBuffer = Array.Empty<float>();

        public MeltySynthProvider(Synthesizer synthesizer, object synLock)
        {
            this.synthesizer = synthesizer;
            this.synLock = synLock;
            waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(synthesizer.SampleRate, 2);
        }
        public WaveFormat WaveFormat => waveFormat;

        // count: 샘플개수 
        public int Read(float[] buffer, int offset, int count)
        {
            int frame = count / 2; // 2 channels (stereo)

            if (leftBuffer == null || leftBuffer.Length < frame)
            {
                leftBuffer = new float[frame];
                rightBuffer = new float[frame];
            }
            lock (synLock)
            {
                synthesizer.Render(leftBuffer.AsSpan(0,frame), rightBuffer.AsSpan(0,frame));
            }   
            for (int i = 0; i < frame; i++)
            {
                // 이게 무슨 의미가 있는 코드인가 싶어 찾아봄
                // call by reference 처럼 보이는데 아니래;
                // 아래 코드처럼 하면 원본값도 잘 바뀌지만, buffer = new float[num]; 여기서 하고 바꾸면 원본값은 안 바뀜
                // 이런 걸 call by sharing 이라고 한다는데(Gemini 피셜) 이게 맞는 명칭인지는 나도 잘...
                buffer[offset + i * 2] = leftBuffer[i];
                buffer[offset + i * 2 + 1] = rightBuffer[i];
            }

            return count;
        }
    }
}
