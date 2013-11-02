using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;
using JPEGCompressor;

namespace JPEGCompressor
{
    public partial class MainForm : Form
    {

        FileInfo[] files;
        String[] extensions = new[] { ".jpg", ".jpeg" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            long totalFilesSize = 0;
            if (ChooseFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String path = ChooseFolder.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(path);
                files = dir.EnumerateFiles().Where(f => extensions.Contains(f.Extension)).ToArray();
                foreach (FileInfo f in files) //compute size of files
                {
                    totalFilesSize = totalFilesSize + f.Length;
                }
                amount.Text = files.Length.ToString();
                size.Text = totalFilesSize.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (files != null)
            {
                var thread = new Thread(() =>
                {
                    progressBar1.Value = 0;
                    int step = 100 / files.Length;
                    foreach (FileInfo element in files) //decode files (not working)
                    {
                        JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                        FileStream stream = new FileStream(@"" + element.FullName, FileMode.Open, FileAccess.Write);
                        encoder.Save(stream); //throw NotSupportedException
                        progressBar1.Value = progressBar1.Value + step;
                    }
                    progressBar1.Value = 100; //end progressbar
                });
                thread.Start();
            }
            else MessageBox.Show("Файлов нету или не выбрана директория!");
        }


    }
}
