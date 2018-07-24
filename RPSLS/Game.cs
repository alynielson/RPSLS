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
           if (isHumanVsComputer == true)
            {
                playerTwo = new Computer();
            }
           else if (isHumanVsComputer == false)
            {
                playerTwo = new Human();
            }
        }
    }
}
