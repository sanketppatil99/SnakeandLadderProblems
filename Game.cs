using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {               
        public static void CheckOptions()
        {
            int position = 0;
            Random random = new Random();
            int diceValue = random.Next(1,7);
            Console.WriteLine("Plyer Roll Dice gate number is : "+diceValue);

            Random random2 = new Random();
            int option = random2.Next(0,3);
            if(option == 0)
            {
                Console.WriteLine("Snake");
                Console.WriteLine("Player moves behind by the number of position recieved in the dice : "+diceValue);
                position = position - diceValue;
                Console.WriteLine(position);
            }
            else if (option == 1)
            {
                Console.WriteLine("Ladder");
                Console.WriteLine("Player moves ahead by the number of position recieved in the dice : " + diceValue);
                position = position + diceValue;
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("No play");
                Console.WriteLine("Player will stay in the same position");
            }
        }
    }
}
