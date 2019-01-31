using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string elements = Console.ReadLine();
            string[] array = elements.Split();

            int n = int.Parse(number);
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
         }   
    }
}
