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
            
            


    }
}
