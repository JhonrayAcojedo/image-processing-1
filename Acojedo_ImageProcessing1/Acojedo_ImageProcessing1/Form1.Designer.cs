namespace Acojedo_ImageProcessing1
{
    partial class Acojedo_ImageProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serpiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OriginalImgBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ProcessedImgBox = new System.Windows.Forms.PictureBox();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.LoadImageBTN = new System.Windows.Forms.Button();
            this.LoadBgBTN = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processImageToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1604, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // processImageToolStripMenuItem
            // 
            this.processImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.serpiaToolStripMenuItem});
            this.processImageToolStripMenuItem.Name = "processImageToolStripMenuItem";
            this.processImageToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.processImageToolStripMenuItem.Text = "DIP";
            this.processImageToolStripMenuItem.Click += new System.EventHandler(this.processImageToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // serpiaToolStripMenuItem
            // 
            this.serpiaToolStripMenuItem.Name = "serpiaToolStripMenuItem";
            this.serpiaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.serpiaToolStripMenuItem.Text = "Sepia";
            this.serpiaToolStripMenuItem.Click += new System.EventHandler(this.serpiaToolStripMenuItem_Click);
            // 
            // OriginalImgBox
            // 
            this.OriginalImgBox.Location = new System.Drawing.Point(63, 55);
            this.OriginalImgBox.Name = "OriginalImgBox";
            this.OriginalImgBox.Size = new System.Drawing.Size(431, 489);
            this.OriginalImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalImgBox.TabIndex = 2;
            this.OriginalImgBox.TabStop = false;
            this.OriginalImgBox.Click += new System.EventHandler(this.OriginalImgBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ProcessedImgBox
            // 
            this.ProcessedImgBox.Location = new System.Drawing.Point(1122, 55);
            this.ProcessedImgBox.Name = "ProcessedImgBox";
            this.ProcessedImgBox.Size = new System.Drawing.Size(431, 489);
            this.ProcessedImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedImgBox.TabIndex = 3;
            this.ProcessedImgBox.TabStop = false;
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.Location = new System.Drawing.Point(613, 55);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(431, 489);
            this.BackgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundBox.TabIndex = 4;
            this.BackgroundBox.TabStop = false;
            this.BackgroundBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoadImageBTN
            // 
            this.LoadImageBTN.Location = new System.Drawing.Point(194, 567);
            this.LoadImageBTN.Name = "LoadImageBTN";
            this.LoadImageBTN.Size = new System.Drawing.Size(154, 69);
            this.LoadImageBTN.TabIndex = 5;
            this.LoadImageBTN.Text = "Load Image";
            this.LoadImageBTN.UseVisualStyleBackColor = true;
            this.LoadImageBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadBgBTN
            // 
            this.LoadBgBTN.Location = new System.Drawing.Point(755, 567);
            this.LoadBgBTN.Name = "LoadBgBTN";
            this.LoadBgBTN.Size = new System.Drawing.Size(154, 69);
            this.LoadBgBTN.TabIndex = 6;
            this.LoadBgBTN.Text = "Load Background";
            this.LoadBgBTN.UseVisualStyleBackColor = true;
            this.LoadBgBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1262, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Subtract";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Acojedo_ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadBgBTN);
            this.Controls.Add(this.LoadImageBTN);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.ProcessedImgBox);
            this.Controls.Add(this.OriginalImgBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acojedo_ImageProcessing";
            this.Text = "Digital Image Processor";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serpiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox OriginalImgBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox ProcessedImgBox;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.Button LoadImageBTN;
        private System.Windows.Forms.Button LoadBgBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
    }
}

