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
            string number = Console.ReadLine();//the size of an array
            string elements = Console.ReadLine();//we write the elements of an array but in one line
            string[] array = elements.Split();//we split by space and add each element to the string

            int n = int.Parse(number);
            
            for (int i = 0; i < n; i++)// we go through the array and print each element twice
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
         }   
    }
}
