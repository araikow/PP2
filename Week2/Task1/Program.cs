using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task1
{
    class Program
    {
        public static bool checkforpalindrome(string s){
        char[] letter = new char[s.Length];//creates an array of chars from given string
        letter = s.ToCharArray();
        int length = s.Length;
        for (int i = 0; i < length / 2; i++)     // 1234321:length = 7;
        {
        if (letter[i] != letter[length - i - 1]) // 1 == 1   
        return false;
        }
         return true;
        }
        static void Main(string[] args)
        {
            string direction = @"C:\Users\Admin\Documents\PP2\PP2\Week2\Task1\1.txt";// location of a file
            string check = File.ReadAllText(direction);//reads the file from given direction
            if(checkforpalindrome(check) == true)// checks if the given string is palindrome or not 
            {
                Console.WriteLine("YES");
            }
            Console.ReadKey();
        }
    }
}
