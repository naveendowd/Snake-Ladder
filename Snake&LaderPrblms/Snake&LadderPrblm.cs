using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
        class Snake_LadderPrblm
    {
        public static void PlayerPosition()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Single player at start Position 0");
            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("Player rolls the dice and get: " + RollDice);
        }
    }
}