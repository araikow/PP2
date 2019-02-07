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
        public static void PrintSpaces(int space)
        {
            for (int i = 0; i < space; i++)
                Console.Write("    ");
        }

        public static void Ex5(DirectoryInfo dir, int space)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                PrintSpaces(space);
                Console.WriteLine(d.Name);
                Ex5(d,space + 1);
            }
            foreach (FileInfo f in dir.GetFiles())
            {
                PrintSpaces(space);
                Console.WriteLine(f.Name);
            }
            
        }
        static void Main(string[] args)
        {
            DirectoryInfo inf = new DirectoryInfo(@"C:\Users\Admin\Documents\books");
            Ex5(inf,1);
            Console.ReadKey();
        }
    }
}
