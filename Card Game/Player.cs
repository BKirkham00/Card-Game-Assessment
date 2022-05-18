using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Player
    {

        public Player(int PlayerID,int Score)
        {
            playerID = PlayerID;
            score = Score;
        }

        public int playerID { get; set; }   
        public int score { get; set; }

        ////Method: ValidatePlayerInput
        //Arguments: int
        //Returns: int
        //Checks if an input entered by the user is valid.
        public int ValidatePlayerInput()
        {
            bool valid = false;
            int input = 0;
            while (valid == false)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    
                }
                finally
                {
                    if (input == 1)
                    {
                        valid = true;
                    }
                    else if (input == 2)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry, that is not a valid input. Please try again.\nenter 1 for yes 2 for no:");
                    }
                }
            }
            return input;
        }
    }
}