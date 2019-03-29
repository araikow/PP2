using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SedakinaTask1
{
    public class Student
    {
        public string name;
        public int number;
        public Student() { }
        public Student(string name,int number)
        {
            this.name = name;
            this.number = number;
        }
        public override string ToString()
        {
            return String.Format("Name:{0},Number:{1}", name, number);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            int n = int.Parse(Console.ReadLine());
            Student[] ss = new Student[n]; 
            for(int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 100);

                ss[i] = new Student(i.ToString(), x);
            }
            FileStream fs = new FileStream("task2a.xml", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Student[]));
            xm.Serialize(fs, ss);
            fs.Close();

             FileStream fs1 = new FileStream("task2a.xml", FileMode.OpenOrCreate,FileAccess.ReadWrite);
             Student[] ss1 = xm.Deserialize(fs1) as Student[];
             fs1.Close();

            foreach(Student st in ss1)
            {
                Console.WriteLine(st);
            }
          
        }
    }
}
