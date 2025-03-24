namespace ImageFilterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            saveOutputImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            algorithmsToolStripMenuItem = new ToolStripMenuItem();
            noiseGeneratorToolStripMenuItem = new ToolStripMenuItem();
            saltPepperNoiseToolStripMenuItem = new ToolStripMenuItem();
            gaussianNoiseToolStripMenuItem = new ToolStripMenuItem();
            medianFilterToolStripMenuItem = new ToolStripMenuItem();
            histogramEqualizationToolStripMenuItem = new ToolStripMenuItem();
            imageInformationToolStripMenuItem = new ToolStripMenuItem();
            originalImageInfoToolStripMenuItem = new ToolStripMenuItem();
            processedImageInfoToolStripMenuItem = new ToolStripMenuItem();
            pictureOriginal = new PictureBox();
            pictureProcessed = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProcessed).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, algorithmsToolStripMenuItem, imageInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem, saveOutputImageToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(175, 22);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // saveOutputImageToolStripMenuItem
            // 
            saveOutputImageToolStripMenuItem.Name = "saveOutputImageToolStripMenuItem";
            saveOutputImageToolStripMenuItem.Size = new Size(175, 22);
            saveOutputImageToolStripMenuItem.Text = "Save Output Image";
            saveOutputImageToolStripMenuItem.Click += saveOutputImageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(175, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // algorithmsToolStripMenuItem
            // 
            algorithmsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noiseGeneratorToolStripMenuItem, medianFilterToolStripMenuItem, histogramEqualizationToolStripMenuItem });
            algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            algorithmsToolStripMenuItem.Size = new Size(78, 20);
            algorithmsToolStripMenuItem.Text = "Algorithms";
            // 
            // noiseGeneratorToolStripMenuItem
            // 
            noiseGeneratorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saltPepperNoiseToolStripMenuItem, gaussianNoiseToolStripMenuItem });
            noiseGeneratorToolStripMenuItem.Name = "noiseGeneratorToolStripMenuItem";
            noiseGeneratorToolStripMenuItem.Size = new Size(197, 22);
            noiseGeneratorToolStripMenuItem.Text = "Noise Generator";
            // 
            // saltPepperNoiseToolStripMenuItem
            // 
            saltPepperNoiseToolStripMenuItem.Name = "saltPepperNoiseToolStripMenuItem";
            saltPepperNoiseToolStripMenuItem.Size = new Size(166, 22);
            saltPepperNoiseToolStripMenuItem.Text = "Salt-Pepper noise";
            saltPepperNoiseToolStripMenuItem.Click += saltPepperNoiseToolStripMenuItem_Click;
            // 
            // gaussianNoiseToolStripMenuItem
            // 
            gaussianNoiseToolStripMenuItem.Name = "gaussianNoiseToolStripMenuItem";
            gaussianNoiseToolStripMenuItem.Size = new Size(166, 22);
            gaussianNoiseToolStripMenuItem.Text = "Gaussian noise";
            gaussianNoiseToolStripMenuItem.Click += gaussianNoiseToolStripMenuItem_Click;
            // 
            // medianFilterToolStripMenuItem
            // 
            medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            medianFilterToolStripMenuItem.Size = new Size(197, 22);
            medianFilterToolStripMenuItem.Text = "Median Filter";
            medianFilterToolStripMenuItem.Click += medianFilterToolStripMenuItem_Click;
            // 
            // histogramEqualizationToolStripMenuItem
            // 
            histogramEqualizationToolStripMenuItem.Name = "histogramEqualizationToolStripMenuItem";
            histogramEqualizationToolStripMenuItem.Size = new Size(197, 22);
            histogramEqualizationToolStripMenuItem.Text = "Histogram Equalization";
            histogramEqualizationToolStripMenuItem.Click += histogramEqualizationToolStripMenuItem_Click;
            // 
            // imageInformationToolStripMenuItem
            // 
            imageInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { originalImageInfoToolStripMenuItem, processedImageInfoToolStripMenuItem });
            imageInformationToolStripMenuItem.Name = "imageInformationToolStripMenuItem";
            imageInformationToolStripMenuItem.Size = new Size(118, 20);
            imageInformationToolStripMenuItem.Text = "Image Information";
            // 
            // originalImageInfoToolStripMenuItem
            // 
            originalImageInfoToolStripMenuItem.Name = "originalImageInfoToolStripMenuItem";
            originalImageInfoToolStripMenuItem.Size = new Size(187, 22);
            originalImageInfoToolStripMenuItem.Text = "Original Image Info";
            originalImageInfoToolStripMenuItem.Click += originalImageInfoToolStripMenuItem_Click;
            // 
            // processedImageInfoToolStripMenuItem
            // 
            processedImageInfoToolStripMenuItem.Name = "processedImageInfoToolStripMenuItem";
            processedImageInfoToolStripMenuItem.Size = new Size(187, 22);
            processedImageInfoToolStripMenuItem.Text = "Processed Image Info";
            processedImageInfoToolStripMenuItem.Click += processedImageInfoToolStripMenuItem_Click;
            // 
            // pictureOriginal
            // 
            pictureOriginal.Location = new Point(0, 30);
            pictureOriginal.Name = "pictureOriginal";
            //pictureOriginal.Size = new Size(400, 400);
            pictureOriginal.TabIndex = 1;
            pictureOriginal.TabStop = false;
            // 
            // pictureProcessed
            // 
            pictureProcessed.Location = new Point(410, 30);
            pictureProcessed.Name = "pictureProcessed";
            //pictureProcessed.Size = new Size(400, 400);
            pictureProcessed.TabIndex = 2;
            pictureProcessed.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 568);
            Controls.Add(pictureProcessed);
            Controls.Add(pictureOriginal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Image Filter Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProcessed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem algorithmsToolStripMenuItem;
        private ToolStripMenuItem medianFilterToolStripMenuItem;
        private PictureBox pictureOriginal;
        private PictureBox pictureProcessed;
        private ToolStripMenuItem saveOutputImageToolStripMenuItem;
        private ToolStripMenuItem noiseGeneratorToolStripMenuItem;
        private ToolStripMenuItem saltPepperNoiseToolStripMenuItem;
        private ToolStripMenuItem gaussianNoiseToolStripMenuItem;
        private ToolStripMenuItem imageInformationToolStripMenuItem;
        private ToolStripMenuItem originalImageInfoToolStripMenuItem;
        private ToolStripMenuItem processedImageInfoToolStripMenuItem;
        private ToolStripMenuItem histogramEqualizationToolStripMenuItem;
    }
}
