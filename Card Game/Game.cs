using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Game : Dice
    {

        ////Method: Game
        //Arguments: int, bool
        //Returns: void
        //Constructor for Game class
        public Game(int Dice, bool Playing) : base(Dice)
        {
            dice = Dice;
            playing = Playing;
        }

        public bool playing { get; set; }

        ////Method: Play
        //Arguments: Object
        //Returns: Void
        //Handles the operation of the game. Calls required funtions and prints game related information to the player.
        public void Play(Player player)
        {
            // Creates a Dice class
            Dice dice = new Dice(0);

            // Calls the Dice roll class and gets 5 new Dice. Sorts the list to make logic easier.
            List<int> DiceList = dice.Dice_Roll_D6();
            DiceList.Sort();

            // Displays a players dice to them.
            Console.WriteLine("player " + player.playerID + " You rolled: " + PrintDice(DiceList));

            // Calls Occurances method
            int[] occurances = Occurances(DiceList);

            // Calls RerollCheck method
            bool check = RerollCheck(occurances);
            //Console.WriteLine(check);

            if (check == true)
            {
                // Creates a list to store the dice that need rerolling
                List<int> Rerolls = new List<int>();
                for(int i = 0; i < 6; i++)
                {
                    //testing print of occurance array
                    
                    if (occurances[i] == 1)
                    {
                        Rerolls.Add(i);
                    }
                }

                // Displays a text based menu to the player to allow them to choose
                // if they want to reroll their remaining dice or not
                Console.WriteLine("player " + player.playerID + " would you like to reroll " + Rerolls.Count().ToString() + " dice?");
                Console.WriteLine("1) yes");
                Console.WriteLine("2) no");
                // Takes player input
                int input = Convert.ToInt32(Console.ReadLine());
                //player.ValidatePlayerInput(input);
                Console.WriteLine();

                if (input == 1)
                {
                    var newdice = dice.Reroll_D6(Rerolls.Count());

                    // Remove all non duplicates from DiceList
                    DiceList = DiceList.GroupBy(x => x)
                     .Where(g => g.Count() > 1)
                     .SelectMany(g => g)
                     .ToList();

                    // Add all values from newdice to DiceList
                    foreach (int i in newdice)
                    {
                        DiceList.Add(i);
                    }

                    DiceList.Sort();
                    Console.WriteLine("player " + player.playerID + " Your new dice are: " + PrintDice(DiceList) + "\n");
                }
            }
            // Calls the score method to tally the scores
            Scores(player, occurances);
        }

        ////Method: PrintDice
        //Arguments: List<int>
        //Returns: string
        //method for making a string out of a players dice for display.
        public string PrintDice(List<int> DiceList)
        {
            string printDice = "";
            foreach (int Dice in DiceList)
            {
                printDice += Dice.ToString() + " ";
            }
            return printDice;
        }

        ////Method: Occurances
        //Arguments: List<int>
        //Returns: array<int>
        //method for finding the number of occurances of a dice value in the list.
        public int[] Occurances(List<int> list)
        {
            // Creates an array to hold the number of times each dice value apears
            int[] occurances = { 0, 0, 0, 0, 0, 0 };
            // Checks each dice rolled and will adjust the occurances array if it finds a multiple occurance
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (list[i] == j)
                    {
                        occurances[j - 1]++;
                    }
                }
            }
            return occurances;
        }

        ////Method: RerollCheck
        //Arguments: array<int>
        //Returns: bool
        //method for Checking if a player qualifies for a reroll, assumes the case to be true and will set to
        //false if it finds a contradicting case.
        public bool RerollCheck(int[] list)
        {
            bool check = true;

            // Looks at each item in list to try and find a contradicting case.
            foreach (int item in list)
            {
                if (item >= 3)
                {
                    check = false;
                }
            }

            // Returns the boolean value.
            return check;
        }

        ////Method: Scores
        //Arguments: class, array<int>
        //Returns: void
        //method for assigning scores to the rolls.
        public void Scores(Player player, int[] list)
        {
            // Foreach loop looks at each item in the occura
            foreach (int i in list)
            {
                if (i == 3)
                {
                    player.score += 3;
                }
                else if (i == 4)
                {
                    player.score += 6;
                }
                else if (i == 5)
                {
                    player.score += 12;
                }
            }
        }

        ////Method: Winner
        //Arguments: Player, Player
        //Returns: 
        //method for Checking who won by reaching 50 points first
        public void Winner(Player player1, Player player2)
        {
            // Tells the user the scores
            Console.WriteLine("Player " + player1.playerID.ToString() + " scored " + player1.score.ToString() + " points.");
            Console.WriteLine("Player " + player2.playerID.ToString() + " scored " + player2.score.ToString() + " points.");

            // Defines player 1 victory
            if (player1.score >= 50)
            {
                Console.WriteLine("Player 1 Wins!");
                playing = false;
            }
            // Defines player 2 victory
            else if (player2.score >= 50)
            {
                Console.WriteLine("Player 2 Wins!");
                playing = false;
            }
        }
    }
}