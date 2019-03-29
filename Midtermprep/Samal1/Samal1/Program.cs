using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Samal1
{
    public class Person{
     public string pname;
    public int age;
    public Movie movue;
        public Person(string pname,int age,Movie movue)
        {
            this.pname = pname;
            this.age = age;
            this.movue = movue;

        }
        public Person()
        {

        }

}
    class Program
    {
        static void Main(string[] args)
        {
            Movie firstMovie = new Movie("Emoji movie", 2017);
            Movie secondMovie = new Movie("50 shades of gray", 2015);
            Movie thirdMovie = new Movie("Shrek", 1999);
            Movie fourthMovie = new Movie("NinjaCop", 1987);
            Person akbar = new Person("Akbar", 29, secondMovie);
            Person ramesh = new Person("Ramesh", 20, firstMovie);
            Person durga = new Person("Durga", 43, fourthMovie);
            Person daler = new Person("Daler", 38, thirdMovie);
              List<Person> l = new List<Person>();
            l.Add(ramesh);
            l.Add(akbar);
            l.Add(durga);
            l.Add(daler);
            
            using (FileStream fs = new FileStream("task2.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
                xm.Serialize(fs,l );
            }
        }
    }
}
