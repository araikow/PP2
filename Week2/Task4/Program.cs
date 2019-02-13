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
        public static void CreateFile()//in this function,we create a file in the given location
        {                               // we use simple fuction Create in FileInfo
          FileInfo file = new FileInfo(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\14.txt");
          file.Create();
        }
        public static void CopyFile()//in this function,we copy file from one path to another
                                      // I use simple function Copyto in FileInfo
        {
            string path1 = @"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\7.txt";
            string path2 = @"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path1\7.txt";
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);
            f1.CopyTo(path2);
        }
        public static void DeleteFile()//in this function,I delete the file from the first folder
        {
         FileInfo f = new FileInfo(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task4\path\7.txt");
         f.Delete();
        }
        static void Main(string[] args)
        {
         CreateFile();//one by one call the function
        }
    }
}








