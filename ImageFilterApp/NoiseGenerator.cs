using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ImageFilterApp
{
    public static class NoiseGenerator
    {
        // Thêm db (decibel) vào ảnh gốc ban đầu
        // Noise Ratio = 10^(-dB / 20) là tỉ lệ hay số lượng pixel bị nhiễu trong ảnh
        public static Bitmap SaltPepperNoiseGenerator(Bitmap input, double db)
        {
            Random random = new Random();
            Bitmap output = new Bitmap(input);

            double noiseRatio = Math.Pow(10, -db / 20);
            int numberNoisyPixels = (int) (input.Width * input.Height * noiseRatio);

            for (int i = 0; i < numberNoisyPixels; i ++)
            {
                int r = random.Next(input.Height);
                int c = random.Next(input.Width);

                Color noisePixel = random.NextDouble() < 0.5 ? Color.Black : Color.White;
                output.SetPixel(c, r, noisePixel);
            }

            return output;
        }
    }
}
