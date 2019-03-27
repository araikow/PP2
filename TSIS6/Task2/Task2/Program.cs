using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{
    public class MyThread
    {
        public string name;
        public Thread threadfield;
        public MyThread(string name)
        {
            this.name = name;
        }
        public void StartThread()
        {
            threadfield = new Thread(Print);
            threadfield.Start();
        }
            public void  Print()
            {
                int i = 1;
                while (i != 5)
                {
                Console.WriteLine((name + " " + i).ToString());
                    i++;
                }
                if (i == 5)
                {
                Console.WriteLine((name + " " +  "end").ToString());
                }  
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyThread th1 = new MyThread("Thread1");
            MyThread th2 = new MyThread("Thread2");
            MyThread th3 = new MyThread("Thread3");


            th1.StartThread();
            th2.StartThread();
            th3.StartThread();
        }
    }
}
