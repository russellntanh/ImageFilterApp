using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterApp
{
    public partial class HistogramForm : Form
    {
        private Bitmap image;
        private Panel histogramPanel;
        public HistogramForm(Bitmap inputImage)
        {
            InitializeComponent();
            this.image = inputImage;
            this.Text = "Histogram";
            this.Size = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            // Panel vẽ histogram
            histogramPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle
            };
            histogramPanel.Paint += HistPanel_Paint;

            this.Controls.Add(histogramPanel);

        }

        private void HistPanel_Paint(object? sender, PaintEventArgs e)
        {
            int[] histogram = ImageHelper.CreateHistogram(this.image);
            int max = histogram.Max();

            // Chuẩn hóa kích thước histogram với Panel
            float scaleX = (float)histogramPanel.Width / 256;
            float scaleY = (float)histogramPanel.Height / max;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            using (Pen pen = new Pen(Color.Black, scaleX))
            {
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)(histogram[i] * scaleY);
                    g.DrawLine(pen, i * scaleX, histogramPanel.Height, i * scaleX, histogramPanel.Height - height);
                }
            }
        }
    }
}
