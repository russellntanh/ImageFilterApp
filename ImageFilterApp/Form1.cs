using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace ImageFilterApp
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Image Files|*.png;*.jpg;*.bmp" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pictureOriginal.Size = new Size(originalImage.Width, originalImage.Height);
                    pictureOriginal.Image = originalImage;
                    pictureOriginal.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            if (originalImage != null)
            {
                processedImage = FilterAlgorithms.MedianFilterProcess(originalImage, 3);
                pictureProcessed.Image = processedImage;
                pictureProcessed.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveOutputImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processedImage == null)
            {
                MessageBox.Show("No image is processed.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;

                    pictureProcessed.Image.Save(saveFileDialog.FileName, format);
                    MessageBox.Show("Save successfully.");
                }
            }
        }

        private void gaussianNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap noisyImage = NoiseGenerator.GaussianNoiseGenerator(originalImage, 10);
            pictureProcessed.Image = noisyImage;
            pictureProcessed.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void saltPepperNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load image first");
                return;
            }

            Bitmap noisyImage = NoiseGenerator.SaltPepperNoiseGenerator(originalImage, 20.0);
            pictureProcessed.Image = noisyImage;
            pictureProcessed.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void originalImageInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No input image.");
                return;
            }
            HistogramForm histogramForm = new HistogramForm(originalImage);
            histogramForm.ShowDialog();
        }

        private void processedImageInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processedImage == null)
            {
                MessageBox.Show("No image processed.");
                return;
            }
            HistogramForm histogramForm = new HistogramForm(processedImage);
            histogramForm.ShowDialog();
        }

        private void histogramEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                processedImage = ImageHelper.EqualizeHistogram(originalImage);
                pictureProcessed.Size = new Size(originalImage.Width, originalImage.Height);
                pictureProcessed.Image = processedImage;
            }
        }

    }
}
