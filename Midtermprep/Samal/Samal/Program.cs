using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Samal
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string s = "Hello";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
                Thread.Sleep(1000);
            }
            Thread color = new Thread(Change);
            color.Start();
        }

        static void Change()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Thread.Sleep(1000);

            }

        }
        
    }
}
