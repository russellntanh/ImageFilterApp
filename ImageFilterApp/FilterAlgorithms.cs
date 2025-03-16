using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterApp
{
    public static class FilterAlgorithms
    {
        public static Bitmap MedianFilterProcess(Bitmap input, int window_size)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            int offset = window_size / 2;

            for (int h = offset; h < input.Height-offset; h++)
            {
                for (int w = offset; w < input.Width-offset; w++)
                {
                    int[] rValue = new int[window_size * window_size];
                    int[] gValue = new int[window_size * window_size];
                    int[] bValue = new int[window_size * window_size];
                    int idx = 0;

                    for (int y = -offset; y <= offset; y++ )
                    {
                        for (int x = -offset; x <= offset; x++)
                        {
                            Color pixel = input.GetPixel(w + x, h + y);
                            rValue[idx] = pixel.R;
                            gValue[idx] = pixel.G;
                            bValue[idx] = pixel.B;
                            idx++;
                        }
                    }

                    Array.Sort(rValue);
                    Array.Sort(gValue);
                    Array.Sort(bValue);

                    Color medianValue = Color.FromArgb(rValue[idx / 2], gValue[idx / 2], bValue[idx / 2]);

                    output.SetPixel(w, h, medianValue);
                }
            }

            return output;
        }
    }
}
