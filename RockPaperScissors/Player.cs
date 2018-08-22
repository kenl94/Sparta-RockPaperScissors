using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Player
    {
        public string rPS;
        public string _rPS;

        public Player()
        {
            ChooseMove();
        }

        public void ChooseMove()
        {
            _rPS = Console.ReadLine().ToUpper();
            rPS = _rPS;
            
        }

    }
}
