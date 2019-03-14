using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string username = Console.ReadLine();
            UserItems user = new UserItems(username);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter){
            Console.CursorVisible = false;
            Game game = new Game();
            game.Start();
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    game.GamePause();
                }
                Console.SetCursorPosition(25, 25);
            Console.WriteLine(user);
            }
            
        }
    }
}
