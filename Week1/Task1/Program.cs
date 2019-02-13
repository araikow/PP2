using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
     public  static bool checkforprime(int n)//the function,which checks for prime of numbers
        {
            if ((n == 1 || n == 0)) return false;//if the number = 1 or 0, we say that they are not prime,so return false
            
            for(int i = 2; i <= Math.Sqrt(n); i++)//here we check if number has divider in the interval [0,sqrt(number)]
            {
                if (n % i == 0) return false;//if it has it is not prime
            }
            return true;
        }
       static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();//create a new list for saving prime numbers
            string line2 = Console.ReadLine();//read the elements
            string[] nums = line2.Split();//create an array from given elements by spliting
            for(int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);//convert each element of array to int
                if(checkforprime(number) == true)//if given number is prime,then add to list
                numbers.Add(number);
            }
            Console.WriteLine(numbers.Count);
            for(int i = 0; i < numbers.Count; i++){//print each elements of a list
                Console.Write(numbers[i] + " ");
             }
            
            Console.ReadKey();
        }
    }
}
