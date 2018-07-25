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
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
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
