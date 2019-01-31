using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
     public  static bool checkforprime(int n)
        {
            if ((n == 1 || n == 0)) return false;
            
            for(int i = 2; i <= (int)Math.Floor(Math.Sqrt(n)); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
       static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            string line2 = Console.ReadLine();
            string[] nums = line2.Split();
            for(int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                if(checkforprime(number) == true)
                numbers.Add(number);
            }
            Console.WriteLine(numbers.Count);
            for(int i = 0; i < numbers.Count; i++){
                Console.Write(numbers[i] + " ");
             }
            
            Console.ReadKey();
        }
    }
}
