using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class UserItems
    {
        public string name;
        public static  int score;
        public UserItems(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return String.Format("Your score: {0}", score);
        }
    }
}
