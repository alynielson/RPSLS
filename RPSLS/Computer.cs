﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Computer()
        {
            name = "Computer";
        }

        public override void GetPlayerAnswer()
        {
            Random rnd = new Random();
            playerAnswer = rnd.Next(1, 6);
        }
    
    }
}
