using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SedakinaTask2
{
    class Program
    {
        public static Object locker = new Object();
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey(true) ;
            StartHead(key);
        }
            
        
        public  static void Green()
        {
            lock (locker)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("_____________________________");
              
                Thread.Sleep(500);
            }
        }
        public static void Red()
        {
            lock (locker)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+++++++++++++++++");
                
                Thread.Sleep(225);
            }
        }
    public static void StartHead(ConsoleKeyInfo key)
    {
        if(key.Key != ConsoleKey.Backspace)
            {
                
                while (true )
                {
                    key = Console.ReadKey(true);
                    Thread t1 = new Thread(Green);
                    t1.Start();
                    Thread t2 = new Thread(Red);
                    t2.Start();
                }
            }
        else
            {
                Console.WriteLine("OK");
            }
    }
    }
}
