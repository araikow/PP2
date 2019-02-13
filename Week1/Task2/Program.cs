using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Student {
            public string name;
            public string ID;
            public int year;
            public Student( string name, string ID, int year){//we create a constructor,which includes three parameter
            this.name = name;
            this.ID = ID;
            this.year = year;
            }
            public void printStudent()
            {
                Console.WriteLine("{0} {1} is the {2} year student.", name,ID,year);//then print 
            }

            public void yearUp() {//in each call of the function the year will increment
               year++;
            }
        }
        static void Main(string[] args)
        { 
            Student stud = new Student("Aray","18BD",0);//we use constructor Student and give values to each parameter
             
            for (int i = 0; i < 6; i++)
            {
                stud.yearUp();
                stud.printStudent();
                Console.ReadKey();
            }
            
        }
       
    }
}
