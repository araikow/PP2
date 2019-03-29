using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YelibayTask1
{
    public class Football
    {
        public Team firstt;
        public Team sect;
        public string stadium;
        public Person referee;
        public Football(Team firstt,Team sect,string stadium,Person referee)
        {
            this.firstt = firstt;
            this.sect = sect;
            this.stadium = stadium;
            this.referee = referee;
        }
        public Football() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person player11 = new Person("Adam", 18, "Kazakhstan");
            Person player12 = new Person("Chelovek", 17, "Russia");
            Person player21 = new Person("Adami", 19, "Kazakhstani");
            Person player22 = new Person("Cheloveki", 18, "Russiai");
            List<Person> team1 = new List<Person>();
            team1.Add(player11);
            team1.Add(player12);
            List<Person> team2 = new List<Person>();
            team2.Add(player21);
            team2.Add(player22);
            Person trainer1 = new Person("Richard", 35, "Germany");
            Person trainer2 = new Person("Fard", 35, "Portugal");
            Team t1 = new Team(team1, "TEAM1", trainer1);
            Team t2 = new Team(team2, "TEAM2", trainer2);
            Person referee = new Person("Almat", 35, "Kazakhstan");
            Football f = new Football(t1, t2, "Orda", referee);
            using(FileStream fs = new FileStream("football.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(Football));
                xm.Serialize(fs, f);
            }
            
        }
    }
}
