using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        public static void PrintSpaces(int space)//shows how much space we need to show all directories and files hierarchically
        {
            for (int i = 0; i < space; i++)
                Console.Write("     ");
        }

        public static void test(DirectoryInfo dir, int space)
        {
            foreach (FileInfo f in dir.GetFiles())//if it is file,show the file's name
            {
                PrintSpaces(space);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())//show the folder's name
            {                                                 // then recall the fucntion (recursion) to show the consistent of the folder
                PrintSpaces(space);
                Console.WriteLine(d.Name);
                test(d, space + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Admin\Documents\PP2\PP2");/
            test(dir, 0);
            Console.ReadKey();
        }
        
    }
}

