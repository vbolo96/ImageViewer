using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        string[] paths;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            if (ofp.ShowDialog(this) == DialogResult.OK && ofp.FileName.Length>0)
            {
                pictureBox1.Load(ofp.FileName);
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                var paths = Directory.EnumerateFiles(fbd.SelectedPath,"*.jpg,*.png",SearchOption.AllDirectories);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] images = Directory.GetFiles(@"C:\Dir", "*.jpg");
            foreach (string image in images)
            {
                pictureBox1.Image = new Bitmap(image);
                System.Threading.Thread.Sleep(5000);
            }

        }

        private void fitScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
