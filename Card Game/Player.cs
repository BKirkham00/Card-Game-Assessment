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
        public int ValidatePlayerInput(int PInput)
        {
            try
            {
                if (PInput > 0 && PInput < 2)
                {
                    PInput = PInput;
                }
            }catch (Exception) 
            {
                Console.WriteLine("Im sorry, that is not a valid input. Please try again.\nenter 1 for yes 2 for no:");
                PInput = Console.Read();
            }
            //finally
            //{
            return PInput;
            //}
        }
    }
}
