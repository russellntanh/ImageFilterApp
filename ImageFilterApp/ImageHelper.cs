using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterApp
{
    public static class ImageHelper
    {
        public static int[] CreateHistogram(Bitmap inputImage)
        {
            int[] histogram = new int[256];

            if (inputImage != null)
            {
                for (int r = 0; r < inputImage.Height; r++)
                {
                    for (int c = 0; c < inputImage.Width; c++)
                    {
                        Color pixel = inputImage.GetPixel(c, r);

                        int grayVal = (pixel.R + pixel.G + pixel.B) / 3;

                        histogram[grayVal]++;
                    }
                }
            }
            return histogram;
        }

        public static void DrawHistogram(Bitmap image, Graphics g, Panel panel)
        {
            if (image == null) return;

            int[] histogram = CreateHistogram(image);
            int max = histogram.Max();

            // Chuẩn hóa để vẽ vừa panel
            float scaleX = (float)panel.Width / 256;
            float scaleY = (float)panel.Height / max;

            g.Clear(Color.White); // Xóa nền

            for (int i = 0; i < 256; i++)
            {
                int height = (int)(histogram[i] * scaleY);
                g.DrawLine(Pens.Black, i * scaleX, panel.Height, i * scaleX, panel.Height - height);
            }
        }

        public static Bitmap EqualizeHistogram(Bitmap inputImage)
        {
            if (inputImage == null)
                return null;

            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Bước 1: Tạo histogram
            int[] histogram = CreateHistogram(inputImage);

            // Bước 2: Tính tổng số pixel
            int totalPixels = width * height;

            // Bước 3: Tính histogram tích lũy (CDF - Cumulative Distribution Function)
            int[] cdf = new int[256];
            cdf[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i];
            }

            // Bước 4: Chuẩn hóa CDF để tạo bảng tra cứu (LUT - Look Up Table)
            int minCdf = cdf.FirstOrDefault(v => v > 0); // CDF nhỏ nhất khác 0
            int[] lut = new int[256];
            for (int i = 0; i < 256; i++)
            {
                lut[i] = (int)(((float)(cdf[i] - minCdf) / (totalPixels - minCdf)) * 255);
            }

            // Bước 5: Áp dụng LUT để tạo ảnh mới
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    int newGray = lut[gray];

                    Color newPixel = Color.FromArgb(newGray, newGray, newGray);
                    outputImage.SetPixel(x, y, newPixel);
                }
            }

            return outputImage;
        }
    }
}
