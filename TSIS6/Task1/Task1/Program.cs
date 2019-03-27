using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] th = new Thread[3];
            for(int i = 0; i< 3; i++)
            {
                th[i] = new Thread(Print);
                th[i].Name = ("THREAD" + " " + i).ToString();
                th[i].Start();
            }
        }
        public  static void Print()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
}
