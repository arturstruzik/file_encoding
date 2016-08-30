using Exocortex.DSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_media_1
{
    public class FourierTransform
    {
        public float[] FFTdata { private set; get; }

        public FourierTransform(byte[] data) 
        {
            FFT(data);
        }

        private void FFT(byte[] data) 
        {
            float[] dataArray = new float[256];
            for (int i = 0; i < 100; i++)
            {
                dataArray[i * 2] = data[i];
            }

            Fourier.FFT(dataArray, dataArray.Length / 2, FourierDirection.Forward);

            for (int i = 0; i < dataArray.Length; i = i + 2)
            {
                dataArray[i] = (float)Math.Sqrt(Math.Pow(dataArray[i], 2) + Math.Pow(dataArray[i + 1], 2));
                dataArray[i + 1] = 0;
            }

            this.FFTdata = dataArray;
        }
    }
}
