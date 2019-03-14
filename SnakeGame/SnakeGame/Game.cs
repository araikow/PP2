using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    public class Game
    {
       public List<GameObject> g_objects;
        public bool isAlive;
        public Snake snake;
        public Food food;
        public Wall wall;
        
        public Game()
        {
            g_objects = new List<GameObject>();
            snake = new Snake(20, 20, "*", ConsoleColor.White);
            food = new Food(0, 0, "@", ConsoleColor.Red);
            wall = new Wall("#", ConsoleColor.Green);
            //int origWidth = Console.WindowWidth;
            //int origHeight = Console.WindowHeight;
            Console.SetWindowSize(42, 42);
            Console.SetBufferSize(42,42);
            
            wall.LoadLevel();
            while (food.IsCollisionwithObject(snake) || food.IsCollisionwithObject(wall))
                food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

            isAlive = true;
        }
        public void Start()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
          
            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                Draw();
                keyInfo = Console.ReadKey();
                if (snake.IsCollisionwithObject(food))
                {
                    UserItems.score++;
                    snake.body.Add(new Point(0, 0));

                    while (food.IsCollisionwithObject(snake) || food.IsCollisionwithObject(wall))
                        food.Generate();
                    if (snake.body.Count % 3  == 0)
                        wall.NextLevel();
                }
                if (snake.IsCollisionwithObject(wall) || snake.CollisionSnaketoSnake())
                {
                    isAlive = false;
                }

                snake.Move(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 20);
            
        }

        public void GamePause()
        {
            File.WriteAllText("food.xml", string.Empty);
            File.WriteAllText("walls.xml", string.Empty);
            File.WriteAllText("snake.xml", string.Empty);
            File.WriteAllText("snake.xml", string.Empty);
            FileStream snake_stream = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.Write);
            FileStream walls_stream = new FileStream("walls.xml", FileMode.OpenOrCreate, FileAccess.Write);
            FileStream food_stream = new FileStream("food.xml", FileMode.OpenOrCreate, FileAccess.Write);
           
            XmlSerializer snake_xml = new XmlSerializer(typeof(Snake));
            XmlSerializer walls_xml = new XmlSerializer(typeof(Wall));
            XmlSerializer food_xml = new XmlSerializer(typeof(Food));

            try
            {
                //xs.Serialize(fs, s);
                snake_xml.Serialize(snake_stream, snake);
                walls_xml.Serialize(walls_stream, wall);
                food_xml.Serialize(food_stream,food);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                food_stream.Close();
                walls_stream.Close();
                snake_stream.Close();
            }
        }

        public void GameResume()
        {

            FileStream snake_stream = new FileStream("snake.xml", FileMode.Open, FileAccess.Read);
            FileStream walls_stream = new FileStream("walls.xml", FileMode.Open, FileAccess.Read);
            FileStream food_stream = new FileStream("food.xml", FileMode.Open, FileAccess.Read);
            
            XmlSerializer snake_xml = new XmlSerializer(typeof(Snake));
            XmlSerializer walls_xml = new XmlSerializer(typeof(Wall));
            XmlSerializer food_xml = new XmlSerializer(typeof(Food));

            try { 

                snake = snake_xml.Deserialize(snake_stream) as Snake;
                wall = walls_xml.Deserialize(walls_stream) as Wall;
                food = food_xml.Deserialize(food_stream) as Food;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                snake_stream.Close();
                walls_stream.Close();
                food_stream.Close();
            }

        }


        public void Draw()
        {
            Console.Clear();
            foreach (GameObject g in g_objects)
            {
                g.Draw();
            }
        }
       
    }
}
