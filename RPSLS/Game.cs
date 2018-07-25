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
        public Player currentRoundWinner;
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            currentRound = 1;
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
                    playerOne = new Human("Player One");
                    playerTwo = new Computer();
                    Console.WriteLine("How many rounds do you want to play?");
                    DetermineNumberOfRounds();
                    break;
                case ("no"):
                    isHumanVsComputer = false;
                    Console.WriteLine("Then it's a two player game! Let's go!");
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    Console.WriteLine("How many rounds do you want to play?");
                    DetermineNumberOfRounds();
                    break;
                default:
                    Console.WriteLine("You did not type Yes or No! Try again.");
                    DetermineIfPlayingComputer();
                    break;
            }
        }

        public void DetermineNumberOfRounds()
        {
            Console.WriteLine("You can play Best of 3, Best of 5, or Best of 7. Enter 3,5, or 7.");
            string answer = Console.ReadLine().Trim();
            switch (answer)
            {
                case ("3"):
                    numberOfRounds = 3;
                    Console.WriteLine("Three rounds! Let's go!");
                    break;
                case ("5"):
                    numberOfRounds = 5;
                    Console.WriteLine("Five rounds! Let's go!");
                    break;
                case ("7"):
                    numberOfRounds = 7;
                    Console.WriteLine("Seven rounds! Let's go!");
                    break;
                default:
                    Console.WriteLine("Wrong! You didn't enter 3, 5, or 7. Try again.");
                    DetermineNumberOfRounds();
                    break;
            }
            PlayRound();
        }

        
        public void PlayRound()
        {
            playerOne.GetPlayerAnswer();
            playerOne.ConvertAnswerToChoice();
            playerTwo.GetPlayerAnswer();
            playerTwo.ConvertAnswerToChoice();
            ChooseRoundWinner();
        }

        public void ChooseRoundWinner()
        {
            if (playerOne.gestureChoice == playerTwo.gestureChoice)
            {
                Console.WriteLine("Tie! Play the round again.");
                PlayRound();
            }
            else
            {
                string[] rockBeats = { "Scissors", "Lizard" };
                string[] paperBeats = { "Rock", "Spock" };
                string[] scissorsBeats = { "Paper", "Lizard" };
                string[] lizardBeats = { "Paper", "Spock" };
                string[] spockBeats = { "Scissors", "Rock" };
                int roundWinner = 2;

                switch (playerOne.gestureChoice)
                {
                    case ("Rock"):
                        if (rockBeats.Contains(playerTwo.gestureChoice))
                        {
                            roundWinner = 1;
                        }
                        break;
                    case ("Paper"):
                        if (paperBeats.Contains(playerTwo.gestureChoice))
                        {
                            roundWinner = 1;
                        }
                        break;
                    case ("Scissors"):
                        if (scissorsBeats.Contains(playerTwo.gestureChoice))
                        {
                            roundWinner = 1;
                        }
                        break;
                    case ("Lizard"):
                        if (lizardBeats.Contains(playerTwo.gestureChoice))
                        {
                            roundWinner = 1;
                        }
                        break;
                    case ("Spock"):
                        if (spockBeats.Contains(playerTwo.gestureChoice))
                        {
                            roundWinner = 1;
                        }
                        break;
                }  
                switch (roundWinner)
                {
                    case 1:
                        Console.WriteLine(playerOne.gestureChoice + " beats " + playerTwo.gestureChoice + "!");
                        Console.WriteLine(playerOne.name + " wins round " + currentRound + "!");
                        playerOne.score++;
                        break;
                    case 2:
                        Console.WriteLine(playerTwo.gestureChoice + " beats " + playerOne.gestureChoice + "!");
                        Console.WriteLine(playerTwo.name + " wins round " + currentRound + "!");
                        playerTwo.score++;
                        break;
                }
                Console.ReadLine();
            }
            

            
            
            
        }
    }
}
