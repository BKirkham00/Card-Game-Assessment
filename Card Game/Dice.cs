using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Dice
    {
        Random dice = new Random();

        //Generates a dice roll for a 6 sided dice
        public int Dice_Roll_D6()
        {
            Random dice = new Random();
            //uses random class, to create a
            int d6 = dice.Next(1,7);
            return d6;
        }

    }
}

