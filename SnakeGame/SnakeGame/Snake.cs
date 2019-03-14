using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake:GameObject
    {

        enum Direction
        {
            NONE,
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        Direction direction = Direction.NONE;
        public Snake(int x,int y,string sign,ConsoleColor color) : base(x, y, sign, color)
        {
           
        }
        public void Move(ConsoleKeyInfo keyInfo) {
            for(int i = body.Count -1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    body[0].x--;
                    break;
                case ConsoleKey.UpArrow:
                    body[0].y--;
                    break;
                case ConsoleKey.RightArrow:
                    body[0].x++;
                    break;
                case ConsoleKey.DownArrow:
                    body[0].y++;
                    break;
                
            }

        }

    }
}