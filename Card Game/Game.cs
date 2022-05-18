using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Game : Dice
    {
        public Game(int Dice) : base(Dice)
        {
            dice = Dice;
        }

        public void Play(Player player)
        {
            // Creates a Dice class
            Dice dice = new Dice(0);
            // Calls the Dice roll class and gets 5 new Dice
            List<int> Dices = dice.Dice_Roll_D6();
            
            

        }

        public void Winner(Player player1, Player player2)
        {
            // Tells the user the scores
            Console.WriteLine("Player " + player1.playerID.ToString() + " scored " + player1.score.ToString() + " points.");
            Console.WriteLine("Player " + player2.playerID.ToString() + " scored " + player2.score.ToString() + " points.");

            // Defines player 1 victory
            if (player1.score > player2.score)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            // Defines player 2 victory
            else if (player1.score < player2.score)
            {
                Console.WriteLine("Player 2 Wins!");
            }
            // Defines a Tie between players
            else
            {
                Console.WriteLine("The Game is a Draw!");
            }

        }
    }
}
