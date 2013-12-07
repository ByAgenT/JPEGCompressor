using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace JPEGCompressor
{
    class FileHelper
    {
        static String[] extensions = new[] { ".jpg", ".jpeg" };
        public static Int64 GetImagesSize(String path)
        {
            Thread.Sleep(1000);
            DirectoryInfo dir = new DirectoryInfo(path);
            long totalFilesSize = 0;
            IEnumerable<FileInfo> files;
            IEnumerable<DirectoryInfo> dirs;
            files = dir.EnumerateFiles().Where(f => extensions.Contains(f.Extension.ToLower()));
            dirs = dir.EnumerateDirectories();
            foreach (FileInfo f in files)
            {
                totalFilesSize += f.Length;
            }
            foreach (DirectoryInfo d in dirs)
            {
                totalFilesSize += GetImagesSize(d.FullName);
            }
            return totalFilesSize;
        }

        public static int GetImagesAmount(String path)
        {
            Thread.Sleep(100);
            int fileAmount = 0;
            DirectoryInfo dir = new DirectoryInfo(path);
            IEnumerable<FileInfo> files;
            IEnumerable<DirectoryInfo> dirs;
            files = dir.EnumerateFiles().Where(f => extensions.Contains(f.Extension.ToLower()));
            dirs = dir.EnumerateDirectories();
            foreach (FileInfo f in files)
            {
                fileAmount += 1;
            }
            foreach (DirectoryInfo d in dirs)
            {
                fileAmount += GetImagesAmount(d.FullName);
            }
            return fileAmount;
        }

        public static void DecodeImages(String path, ProgressBar progressBar)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            IEnumerable<FileInfo> files;
            IEnumerable<DirectoryInfo> dirs;
            files = dir.EnumerateFiles().Where(f => extensions.Contains(f.Extension));
            dirs = dir.EnumerateDirectories();
            progressBar.Value = 0;
            int step = 100 / GetImagesAmount(path);
            foreach (FileInfo f in files)
            {
                //JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                //FileStream stream = new FileStream(@"" + f.FullName, FileMode.Open, FileAccess.Write);
                //encoder.Save(stream); //throw NotSupportedException
                progressBar.Value += 1;
            }
            foreach (DirectoryInfo d in dirs)
            {
                DecodeImages(d.FullName, progressBar);
            }
        }


    }
}
