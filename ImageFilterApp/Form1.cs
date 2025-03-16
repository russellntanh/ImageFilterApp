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
                    pictureOriginal.Image = originalImage;
                    pictureOriginal.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureProcessed.Image = null;
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

        private void noiseGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
