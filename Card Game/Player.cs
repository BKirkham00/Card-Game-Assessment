using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Player : Dice
    {
        private int playerID;
        private int score;

        public Player(int PlayerID,int Score)
        {
            playerID = PlayerID;
            score = Score;
        }

        public int PlayerID { get; set; }   
        public int Score { get; set; }
            
            


    }
}
