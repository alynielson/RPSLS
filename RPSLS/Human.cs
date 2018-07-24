using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        public Human(string playerNumber)
        {
            score = 0;
            Console.WriteLine(playerNumber + ", what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
        public override void GetPlayerAnswer()
        {
            Console.WriteLine(name + "'s turn! Choose a number.");
            for (int i = 0; i < gestures.Count; i ++)
            {
                Console.WriteLine((i + 1) + ". " + gestures[i]);
            }
            string playerResponse = Console.ReadLine();
            string[] validResponseArray = { "1", "2", "3", "4", "5" };
            if (validResponseArray.Contains(playerResponse))
            {
               playerAnswer = Int32.Parse(playerResponse);
            }
            else
            {
                Console.WriteLine("You didn't type a number from 1 to 5! Try again.");
                GetPlayerAnswer();
            }
            

        }

    }
}
