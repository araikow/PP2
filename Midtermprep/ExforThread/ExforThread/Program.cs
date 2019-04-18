using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExforThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread t = new Thread(Display);
            t.Start();
            //Thread tt = new Thread(Print);
            //tt.Start();
        }
        private static void Display()
        {
            Random rand = new Random();
            while (true)
            {
                int x = rand.Next(1, 32);
                int y = rand.Next(1, 32);
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("@");
                Thread.Sleep(400);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ");
            }  
        }
    }
}
