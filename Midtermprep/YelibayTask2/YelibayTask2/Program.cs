using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YelibayTask2
{
    class Program
    {
        public static int x = 16;
        public static int y = 0;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DisplayGun();
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Backspace)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("$");
            }
            Thread t = new Thread(Shot);
            t.Start();
        }
        public static void DisplayGun()
        {
            string fileName = "Gun.txt";
            StreamReader sr = new StreamReader(fileName);

            string[] rows = sr.ReadToEnd().Split('\n');

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (rows[i][j] == '#')

                        Console.Write(rows[i][j]);
                }
                Console.WriteLine();
            }
            sr.Close();
        }
        public  static void Shot()
        {
                while(true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    x++;

                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("$");
                    
                    Thread.Sleep(400);
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                    
                    
                }
        }
    }
}