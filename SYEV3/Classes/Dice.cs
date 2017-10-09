using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
    class Dice
    {

        static Random dice = new Random();
        static int d1;


        public static int GetDice()
        {
            d1 = (int)dice.Next(1, 7);

            return d1;
        }
    }
}
