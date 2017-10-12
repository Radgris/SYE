using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
      class Rules
    {




         public  static bool CheckWinner(Token token, int tempdice)
        {

            if (token.Casilla.Numero+ tempdice >= 30)
            {
                
                Console.WriteLine(token.Player + " ah ganado el juego");

                return true;
            }

            else
            {
                Console.WriteLine("es el turno del jugador " + token.Player);

                return false;
            }

          
        }
    }
}
