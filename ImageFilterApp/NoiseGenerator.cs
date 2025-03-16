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
        private static Random random = new Random();

        // Thêm nhiễu muối tiêu x dB (decibel) vào ảnh gốc ban đầu
        // Noise Ratio = 10^(-dB / 20) là tỉ lệ hay số lượng pixel bị nhiễu trong ảnh
        public static Bitmap SaltPepperNoiseGenerator(Bitmap input, double db)
        {
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

        // Thêm nhiễu Gaussian vào anh gốc ban đầu
        public static Bitmap GaussianNoiseGenerator(Bitmap image, double dB)
        {
            Bitmap noisyImage = new Bitmap(image);

            double variance = 255 * 255 / Math.Pow(10, dB / 10);
            double stdDev = Math.Sqrt(variance);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Generate Gaussian noise
                    int noiseR = Clamp(pixel.R + GenerateGaussianNoise(stdDev), 0, 255);
                    int noiseG = Clamp(pixel.G + GenerateGaussianNoise(stdDev), 0, 255);
                    int noiseB = Clamp(pixel.B + GenerateGaussianNoise(stdDev), 0, 255);

                    noisyImage.SetPixel(x, y, Color.FromArgb(noiseR, noiseG, noiseB));
                }
            }

            return noisyImage;
        }

        private static int GenerateGaussianNoise(double stdDev)
        {
            // Box-Muller transform to generate normally distributed noise
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

            return (int)(randStdNormal * stdDev);
        }

        private static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
