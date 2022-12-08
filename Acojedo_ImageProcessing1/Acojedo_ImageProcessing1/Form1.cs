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

        private void OriginalImgBox_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
