using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int space) // function,which print spaces
        {
            for (int i = 0; i < space; i++)
                Console.Write("    ");
        }

        public static void Getfiledirect(DirectoryInfo dir, int space)
        {
             foreach (FileInfo f in dir.GetFiles())//we find files
            {
                PrintSpaces(space);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine(space);
                Console.WriteLine(d.Name);
                Getfiledirect(d,space + 1);//recall the function again
            }
           
            
        }
        static void Main(string[] args)
        {
            DirectoryInfo inf = new DirectoryInfo(@"C:\Users\Admin\Documents\books");
            Getfiledirect(inf,0);
            Console.ReadKey();
        }
    }
}
