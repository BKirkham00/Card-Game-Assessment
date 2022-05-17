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
            Player Player_1 = new Player(1,0);
            Player Player_2 = new Player(2,0);

            //Player_1.PlayerID = 1;
            //Player_2.PlayerID = 2;


            Console.WriteLine("Player " + Player_1.playerID.ToString() + " scored " + Player_1.score.ToString() + " points.");
            Console.WriteLine("Player " + Player_2.playerID.ToString() + " scored " + Player_2.score.ToString() + " points.");


        }

    }

}
