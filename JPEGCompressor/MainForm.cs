using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;

namespace JPEGCompressor
{
    public partial class MainForm : Form
    {

        FileInfo[] jpgfiles;
        FileInfo[] jpegfiles;
        int step;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long size = 0; //size of files

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //open FolderBrowserDialog
            {
                String path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(path);
                jpgfiles = dir.GetFiles("*.jpg");
                jpegfiles = dir.GetFiles("*.jpeg");
                foreach (FileInfo f in jpegfiles) //compute size of .jpeg files
                {
                    size = size + f.Length;
                }
                foreach (FileInfo f in jpgfiles) //compute size of .jpg files
                {
                    size = size + f.Length;
                }
                int FileAmountJPG = jpgfiles.Length;
                int FileAmountJPEG = jpegfiles.Length;
                step = 100 / (FileAmountJPEG + FileAmountJPG);

                label3.Text = String.Join(" ", FileAmountJPEG + FileAmountJPG);
                label4.Text = String.Join(" ", size);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            foreach (FileInfo element in jpegfiles) //decode jpeg files
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                FileStream stream = new FileStream(element.Name, FileMode.Open);
                encoder.Save(stream);
                progressBar1.Value = progressBar1.Value + step;
            }
            foreach (FileInfo element in jpgfiles) //decode jpg files
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                FileStream stream = new FileStream(element.FullName, FileMode.Open, FileAccess.Write);
                encoder.Save(stream);
                progressBar1.Value = progressBar1.Value + step;
            }
            progressBar1.Value = 100; //end progressbar
        }
    }
}
