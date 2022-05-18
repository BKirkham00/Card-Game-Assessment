using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Dice
    {
        public Dice(int Dice)
        {
            dice = Dice;
        }

        public int dice { get; set; }

        ////Method: Dice_Roll_D6
        //Arguments: Void
        //Returns: List<int>
        //Generates a dice roll for a 6 sided dice and then adds 5 of them to a list.
        public List<int> Dice_Roll_D6()
        {
            Random rnd = new Random();
            List<int> dicelist = new List<int>();
            //uses random class, to create a
            for (int i = 0; i < 5; i++)
            {
                dice = rnd.Next(1, 7);
                dicelist.Add(dice);
            }
            return dicelist;
        }

        ////Method: Reroll_D6
        //Arguments: int
        //Returns: List<int>
        //Generates a number of new dice equal to the number of rerolls requested.
        public List<int> Reroll_D6(int RerollCount)
        {
            Random rnd = new Random();
            List<int> newdice = new List<int> { };
            for (int i = 0; i < RerollCount; i++)
            {
                int die = rnd.Next(1, 7);
                newdice.Add(die);
            }
            return newdice;
        }
    }
}
