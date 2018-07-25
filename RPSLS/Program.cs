using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n \nRules: \nRock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
            Game newGame = new Game();
            newGame.StartGame();
            newGame.PlayGame();
            Console.WriteLine("Press any key to play again!");
            Console.ReadLine();
            Console.Clear();
            Main();

        }
    }
}
