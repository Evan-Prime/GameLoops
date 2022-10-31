using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoops
{
    internal class Program
    {
        static int[] ammo = new int[] { 6, 2, 25, 50, 10 };

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" Game Loops!");
            Console.WriteLine();
            // count from 1..10
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count++;
                Console.WriteLine(" " + count);
            }

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine(" Game Loops!");
            Console.WriteLine();
            int start = 0;
            int end = 20;

            int score = start;

            // count from start..end
            while (score < end)
            {
                score++;
                Console.WriteLine(" " + score);
            }

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine(" Game Loops!:");
            Console.WriteLine(" Weapon Edition");
            Console.WriteLine();
            // ammo count
            int index = 0;
            int indexEnd = 4;
            int weaponNum = index + 1;

            while (index <= indexEnd)
            {
                Console.WriteLine(" Weapon #"+ weaponNum + " Ammo: " + ammo[index]);
                index++;
                weaponNum++;
            }

            Console.ReadKey(true);
        }
    }
}
