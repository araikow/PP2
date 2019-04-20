using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinished
{
    class CalcState
    {
        public double first_number = 0;
        public double second_number = 0;
        public double result;
        public string operation;

        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = first_number + second_number;
                    break;
                case "-":
                    result = first_number - second_number;
                    break;
                case "X":
                    result = first_number * second_number;
                    break;
                case "/":
                    result = first_number / second_number;
                    break;
                case "x^2":
                    result = first_number * first_number;
                    break;
                case "1/x":
                    result = 1 / first_number;
                    break;
                case "sqrt":
                    result = Math.Sqrt(first_number);
                    break;
                case "x!":
                    int sum = 1;
                    for (int i = 1; i <= first_number; i++)
                    {
                        sum *= i;
                    }
                    result = sum;
                    break;
                case "x^y":
                    result = Math.Pow(first_number, second_number);
                    break;
                case "+/-":
                    result = (-1) * first_number;
                    break;
                case "e":
                    result = Math.E;
                    break;
                case "pi":
                    result = Math.PI;
                    break;
                case "sin":
                    result = Math.Sin(first_number * Math.PI / 180);
                    break;
                case "tan":
                    result = Math.Tan(first_number * (Math.PI / 180));
                    break;
                case "10^x":
                    result = Math.Pow(10, first_number);
                    break;
                case "log":
                    result = Math.Log(first_number);
                    break;
                case "GCD":
                    result = gcd(first_number, second_number);
                    break;
                case "LCM":
                    result = lcm(first_number, second_number);
                    break;
                case "Palin":
                    if (isPalindrome(first_number))
                    {
                        result = 1;
                    }
                    else result = 0;
                    break;
                case "Prime":
                    if (isPrime(first_number))
                    {
                        result = 1;
                    }
                    else result = 0;
                    break;
                case "Conv":
                    string s = ((Convert.ToString((int)first_number, 2)));
                    result = int.Parse(s);
                    break;
                case "Func":
                    //result = first_number, second_number;
                    break;
            }
        }

        private double gcd(double n, double m)
        {
            while (m != n)
            {
                if (m > n)
                    m = m - n;
                else
                    n = n - m;
            }
            return m;
        }
        private double lcm(double n, double m)
        {
            return m * n / gcd(m, n);
        }
        private bool isPalindrome(double n)
        {
            string s = n.ToString();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        private bool isPrime(double n)
        {
            if (n == 1) return false;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
