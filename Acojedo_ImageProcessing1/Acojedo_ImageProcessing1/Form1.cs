using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Acojedo_ImageProcessing1
{
    public partial class Acojedo_ImageProcessing : Form
    {
        Bitmap loaded, processed;
        public Acojedo_ImageProcessing()
        {
            InitializeComponent();
        }

        private void processImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            OriginalImgBox.Image = loaded;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for(int x = 0; x < loaded.Width; x++)
                for(int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }

            ProcessedImgBox.Image = processed;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);

                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    processed.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }

            ProcessedImgBox.Image = processed;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, Color.FromArgb(255-pixel.R, 255 - pixel.G, 255 - pixel.B));
                }

            ProcessedImgBox.Image = processed;
        }

        private void OriginalImgBox_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
