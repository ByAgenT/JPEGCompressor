using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        String[] extensions = new[] { ".jpg", ".jpeg" };
        IEnumerable<FileInfo> files;
        IEnumerable<DirectoryInfo> dirs;
        int filesAmount = 0;
        String path;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ChooseFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var thread = new Thread(() =>
                {
                    path = ChooseFolder.SelectedPath;
                    long size = FileHelper.GetImagesSize(path);
                    sizeLabel.Invoke(new Action<long>(s =>
                        {
                            sizeLabel.Text = s.ToString(CultureInfo.InvariantCulture);
                        }), size);
                    countLabel.Invoke(new Action<int>(s =>
                        {
                            countLabel.Text = s.ToString(CultureInfo.InvariantCulture);
                        }), FileHelper.GetImagesCount(path));
                });
                thread.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filesAmount >= 1)
            {
                var thread = new Thread(() =>
                {
                    FileHelper.DecodeImages(path, CompressProgressBar);
                });
                thread.Start();
            }
            else MessageBox.Show("Файлов нету или не выбрана директория!");
        }


    }
}
