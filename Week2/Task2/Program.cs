using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool checkforprime(int x)//the fucntion which checks for prime(already was used)
        {
            if (x == 1 || x == 0) return false;
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string check = File.ReadAllText(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task2\2.txt");//read a file from given location then saves it to string
            string ans = "";//string,which can save prime numbers
            string[] answer = check.Split(' ');//creates array of strings from (file contents)
            foreach(string s in answer)
            {
                int x = int.Parse(s);
                if (checkforprime(x) == true)
                    ans = ans + " " + x;
            }
           // Console.WriteLine(ans);
            File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Week2\Task2\2ans.txt", ans);//writes all prime numbers to another file using function of FileInfo
        }
    }
}
