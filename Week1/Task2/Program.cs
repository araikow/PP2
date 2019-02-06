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
            public Student( string name, string ID, int year){
            this.name = name;
            this.ID = ID;
            this.year = year;
            }
            public void printStudent()
            {
                Console.WriteLine("{0} {1} is the {2} year student.", name,ID,year);
            }

            public void yearUp() {
               year++;
            }
        }
        static void Main(string[] args)
        {
            Student stud = new Student("Aray","18BD",0);
            
            for (int i = 0; i < 6; i++)
            {
                stud.yearUp();
                stud.printStudent();
                Console.ReadKey();
            }
            
        }
       
    }
}
