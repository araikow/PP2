using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YelibayTask1
{
     public class Team
     {
        public List<Person> players;
        public string teamname;
        public Person coach;

        public Team() { }
        public Team(List<Person>players,string teamname,Person coach)
        {
            this.players = players;
            this.teamname = teamname;
            this.coach = coach;
        }
        public override string ToString()
        {
            return String.Format("Players: {0},Team: {1}, Trainer: {2}", players, teamname, coach);
        }
     }
}
