using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoops
{
    internal class Program
    {
        
        static bool gameOver; // true or false
        static int x; // play position
        static int y; // play position

        static void Main(string[] args)
        {
            gameOver = false;

            x = 0;
            y = 0;

            // game loop
            while(gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw();
            }

            Console.WriteLine("Game Over!");
            Console.ReadKey();
        }

        static void PlayerUpdate()
        {
            // read user input
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            //Console.WriteLine(input);
            //Console.WriteLine(input.KeyChar);
            //Console.WriteLine(input.Key);
            // update player position
            if (input.Key == ConsoleKey.W)
            {
                y--;
            }
            if (input.Key == ConsoleKey.S)
            {
                y++;
            }
            if (input.Key == ConsoleKey.D)
            {
                x++;
            }
            if (input.Key == ConsoleKey.A)
            {
                x--;
            }
            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }

            // DEBUG
            //Console.WriteLine("(" + x + "," + y + ")");

        }

        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("()^-^)");
        }
    }
}
