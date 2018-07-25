using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        bool isHumanVsComputer;
        int numberOfRounds;
        int currentRound;
        bool isGameOverEarly = false;
        Player playerOne;
        Player playerTwo;
        string[] rockBeats = { "Scissors", "Lizard" };
        string[] paperBeats = { "Rock", "Spock" };
        string[] scissorsBeats = { "Paper", "Lizard" };
        string[] lizardBeats = { "Paper", "Spock" };
        string[] spockBeats = { "Scissors", "Rock" };

        public Game()
        {
            currentRound = 1;
        }

        public void StartGame()
        {
            DetermineIfPlayingComputer();
            DetermineNumberOfRounds();
        }

        private void DetermineIfPlayingComputer()
        {
            Console.WriteLine("\nYou can either play against the computer (single player) or play against a friend (2 player).");
            Console.WriteLine("Will you be playing You vs. The Computer? Type Yes or No.");
            string answer = Console.ReadLine().ToLower().Trim();
            switch (answer)
            {
                case ("yes"):
                    isHumanVsComputer = true;
                    Console.WriteLine("You vs. me! Let's go!");
                    playerOne = new Human("Player One");
                    playerTwo = new Computer();
                    break;
                case ("no"):
                    isHumanVsComputer = false;
                    Console.WriteLine("Then it's a two player game! Let's go!");
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    break;
                default:
                    Console.WriteLine("You did not type Yes or No! Try again.");
                    DetermineIfPlayingComputer();
                    break;
            }
        }

        private void DetermineNumberOfRounds()
        {
            Console.WriteLine("How many rounds do you want to play?");
            Console.WriteLine("You can play Best of 3, Best of 5, or Best of 7. Enter 3,5, or 7.");
            string answer = Console.ReadLine().Trim();
            switch (answer)
            {
                case ("3"):
                    numberOfRounds = 3;
                    Console.WriteLine("Three rounds! Let's go! Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ("5"):
                    numberOfRounds = 5;
                    Console.WriteLine("Five rounds! Let's go! Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ("7"):
                    numberOfRounds = 7;
                    Console.WriteLine("Seven rounds! Let's go! Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Wrong! You didn't enter 3, 5, or 7. Try again.");
                    DetermineNumberOfRounds();
                    break;
            }
        }

        

        public void PlayGame()
        {
            while (currentRound <= numberOfRounds)
            {
                PlayRound();
                ChooseRoundWinner();
                if (currentRound < numberOfRounds)
                {
                    CheckIfPlayerWinsGameEarly();
                }
                currentRound++;
                if (isGameOverEarly)
                {
                    break;
                }
                
            }
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine(playerOne.name + " won " + playerOne.score + " rounds out of " + (currentRound -1) + " (" + numberOfRounds + " round game).");
                Console.WriteLine(playerOne.name + " wins the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won " + playerTwo.score + " rounds out of " + (currentRound - 1) + " (" + numberOfRounds + " round game).");
                Console.WriteLine(playerTwo.name + " wins the game!");
            }
            Console.ReadLine();
        }
        
        private void PlayRound()
        {
            Console.WriteLine("Round " + currentRound + ": "+ playerOne.score + " to " + playerTwo.score);
            playerOne.GetPlayerAnswer();
            playerOne.ConvertAnswerToChoice();
            if (!isHumanVsComputer)
            {
                Console.WriteLine("Press any key to clear the console so " + playerTwo.name + " will not see your choice.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Round " + currentRound + ": " + playerOne.score + " to " + playerTwo.score);
            }
            playerTwo.GetPlayerAnswer();
            playerTwo.ConvertAnswerToChoice();
        }

        private void ChooseRoundWinner()
        {
            if (playerOne.gestureChoice == playerTwo.gestureChoice)
            {
                Console.WriteLine("Tie! Play the round again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                PlayRound();
                ChooseRoundWinner();
            }
            else
            {
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
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
            }    
        }
        private void CheckIfPlayerWinsGameEarly()
        {
            double pointsToWin = (Convert.ToDouble(numberOfRounds) / 2) + 0.5;
            if (playerOne.score == pointsToWin)
            {
                Console.WriteLine(playerOne.name + " has won enough rounds to finish the game early!");
                isGameOverEarly = true;
            }
            else if (playerTwo.score == pointsToWin)
            {
                Console.WriteLine(playerTwo.name + " has won enough rounds to finish the game early!");
                isGameOverEarly = true;
            }
        }
    }
}
