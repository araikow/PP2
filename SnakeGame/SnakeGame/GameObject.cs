using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class GameObject
    {
        public  List<Point> body;
        public string sign;
        public ConsoleColor color;
        public Point head;
        public GameObject(int x,int y,string sign,ConsoleColor color)
        {
             body = new List<Point>
             {
                new Point(x,y)
             };
            this.sign = sign;
            this.color = color;
        }
        public void Draw()
        {
        head = body.Last();
        Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public  bool IsCollisionwithObject(GameObject obj)
        {
            foreach (Point p in obj.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                {
                    return true;
                }

            }
            return false;
        }
        public bool CollisionSnaketoSnake()
        {
            for (int i = 2; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }
    }
}
