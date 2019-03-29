using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YelibayTask1
{
    public class Person
    {
        public string name;
        public int age;
        public string country;

        public Person() { }
        public Person(string name,int age,string country)
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }
        public override string ToString()
        {
            return String.Format("Name : {0}, age: {1}, country: {2}", name, age, country);
        }
    }
    
}
