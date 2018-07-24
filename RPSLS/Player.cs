using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public int score;
        public List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public string name;
        public string gestureChoice;
        public int playerAnswer;



        public abstract void GetPlayerAnswer();
    }
}
