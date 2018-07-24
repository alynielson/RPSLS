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

        public void ConvertAnswerToChoice()
        {
            switch (playerAnswer)
            {
                case (1):
                    gestureChoice = gestures[0];
                    break;
                case 2:
                    gestureChoice = gestures[1];
                    break;
                case 3:
                    gestureChoice = gestures[2];
                    break;
                case 4:
                    gestureChoice = gestures[3];
                    break;
                case 5:
                    gestureChoice = gestures[4];
                    break;
            }
            Console.WriteLine(name + " chose " + gestureChoice + "!");
            Console.ReadLine();
        }
    }
}
