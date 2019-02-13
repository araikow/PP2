using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void F2()
        {
            int n = int.Parse(Console.ReadLine());  
            string[,] a = new string[n, n];// we create two-dimensional array 

            for (int i = 0; i < n; i++)//we print [*] in such rule
                                        // the first line - [*]
                                        // the second line -[*] [*] 
                for (int j = 0; j < i + 1; j++)
                    a[i, j] = "[*]";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            F2();
            Console.ReadKey();
        }
    }
}
