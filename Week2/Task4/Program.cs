using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void CreateFile()
        {
          FileInfo file = new FileInfo(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\5.txt");
          FileStream f = file.Create();
        }
        public static void CopyFile()
        {
            string path1 = @"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\5.txt";
            string path2 = @"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path1\5.txt";
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);
            f1.CopyTo(path2);
        }
        public static void DeleteFile()
        {
         FileInfo f = new FileInfo(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\5.txt");
         f.Delete();
        }
        static void Main(string[] args)
        {
         CreateFile();
        }
    }
}








