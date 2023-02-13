using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {       
        public static void StartGame()
        {
            int position = 0;
            int player1;
            Console.WriteLine("Single player at start position is : " + position);
        }

        public static void PlayerRollDice()
        {
            Random random = new Random();
            int diceValue = random.Next(1,7);
            Console.WriteLine("Plyer Roll Dice gate number is : "+diceValue);
        }
    }
}
