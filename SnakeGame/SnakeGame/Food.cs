using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food : GameObject
    {
        public Food(int x, int y, string sign, ConsoleColor color) : base(x, y, sign, color)
        {

        }
        public void Generate()
        {
            Random rand = new Random();
            int x = rand.Next(2, 30);
            int y = rand.Next(2,30);

            body[0].x = x;
            body[0].y = y;
        }

    }


}
