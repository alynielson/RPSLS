using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public bool isHumanVsComputer;
        public int numberOfRounds;
        public int currentRound;
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            playerOne = new Human();
            Console.WriteLine("You can either play against the computer (single player) or play against a friend (2 player).");
            DetermineIfPlayingComputer();
        }

        public void DetermineIfPlayingComputer()
        {
            Console.WriteLine("Will you be playing You vs. The Computer? Type Yes or No.");
            string answer = Console.ReadLine().ToLower().Trim();
            switch (answer)
            {
                case ("yes"):
                    isHumanVsComputer = true;
                    Console.WriteLine("You vs me! Let's go!");
                    playerTwo = new Computer();
                    Console.ReadLine();
                    break;
                case ("no"):
                    isHumanVsComputer = false;
                    Console.WriteLine("Then it's a two player game! Let's go!");
                    playerTwo = new Human();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You did not type Yes or No! Try again.");
                    DetermineIfPlayingComputer();
                    break;
            }
        }
    }
}
