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
        Bitmap loaded, processed, green, background;
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

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color sample;
            Color gray;
            Byte graydata;
            //Grayscale Convertion;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    sample = loaded.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    loaded.SetPixel(x, y, gray);
                }
            }

            //histogram 1d data;
            int[] histdata = new int[256]; // array from 0 to 255
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    sample = loaded.GetPixel(x, y);
                    histdata[sample.R]++; // can be any color property r,g or b
                }
            }

            // Bitmap Graph Generation
            // Setting empty Bitmap with background color
            processed = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processed.SetPixel(x, y, Color.White);
                }
            }
            // plotting points based from histdata
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, processed.Height - 1); y++)
                {
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
                }
            }

            ProcessedImgBox.Image = processed;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ProcessedImgBox.Image.Save(saveFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void serpiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    double tr = 0.393 * (pixel.R) + 0.769 * pixel.G + 0.189 * pixel.B; 
                    double tg = 0.349 * (pixel.R) + 0.686 * pixel.G + 0.168 * pixel.B;
                    double tb = 0.272 * (pixel.R) + 0.534 * pixel.G + 0.131 * pixel.B;

                    int valueR = tr > 255 ? 255 : (int)tr;
                    int valueG = tg > 255 ? 255 : (int)tg;
                    int valueB = tb > 255 ? 255 : (int)tb;

                    processed.SetPixel(x, y, Color.FromArgb(valueR, valueG, valueB));
                }

            ProcessedImgBox.Image = processed;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OriginalImgBox_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
