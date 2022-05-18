using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dice_Game
{
    static class Program
    {
        static void Main(string[] args)
        {
            Player Player_1 = new Player(1, 0);
            Player Player_2 = new Player(2, 0);

            Game game = new Game(0, true);

            // Introduction to the game
            Console.WriteLine("Welcome to my Dice Game!\nYou will take turns to roll dice scoring points on 3 of a kind or higher.\n" +
                "if you only get 2 of a kind or lower, you will be able to reroll any remaining dice once to try and score.");

            // int to track number of rounds played
            int RoundNo = 1;
               
            // Loop runs while the value playing is true. Calls the play method for each player.
            while (game.playing == true)
            {
                Console.WriteLine("\nround " + RoundNo + "\n");
                RoundNo++;

                game.Play(Player_1);
                game.Play(Player_2);
                game.Winner(Player_1, Player_2);
            }
        }
    }
}