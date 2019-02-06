using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool checkforprime(int x)
        {
            if (x == 1 || x == 0) return false;
            for(int i = 2; i <= (int)Math.Floor(Math.Sqrt(x)); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string check = System.IO.File.ReadAllText(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task2\2.txt");//read a file and save it to string
            string ans = "";//string,which can save prime numbers
            string[] answer = check.Split(' ');//creates array of strings from (file)
            foreach(string s in answer)
            {
                int x = int.Parse(s);
                if (checkforprime(x) == true)
                    ans = ans + " " + x;
            }
           // Console.WriteLine(ans);
            System.IO.File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task2\2ans.txt", ans);//writes all prime numbers to another file
        }
    }
}
