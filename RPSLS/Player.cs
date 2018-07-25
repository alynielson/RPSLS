using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public int score = 0;
        protected List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public string name;
        public string gestureChoice;
        protected int playerAnswer;

        public abstract void GetPlayerAnswer();

        public void ConvertAnswerToChoice()
        {
            gestureChoice = gestures[playerAnswer - 1];
            Console.WriteLine(name + " chose " + gestureChoice + "!");
        }
    }
}
