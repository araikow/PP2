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
                case "+" : 
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
                    result = first_number*first_number;
                    break;
                case "1/x":
                    result = 1/first_number;
                    break;
                case "sqrt":
                    result = Math.Sqrt(first_number);
                    break;
                case "x!":
                    int sum = 1;
                        for (int  i = 1; i <= first_number; i++)
                        {
                        sum *= i;
                        }
                        result = sum;
                        break;
                case "x^y":
                    result = Math.Pow(first_number,second_number);
                    break;
                case "+/-":
                    result = (-1)*first_number;
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
                    result = Math.Pow(10,first_number);
                    break;
                case "log":
                    result =Math.Log(first_number);
                    break;
            }
        }
    }

}
