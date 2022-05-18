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
            
            Game game = new Game(0);

            game.Play(Player_1);
            game.Winner(Player_1, Player_2);
            
            
            

        


        }

    }

}
