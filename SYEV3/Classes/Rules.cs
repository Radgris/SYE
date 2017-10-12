using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
      class Rules
    {




         public  static bool CheckWinner(Token token)
        {

            if (token.Casilla.Numero >= 29)
            {
                
                Console.Write(token.Player + "ah ganado el juego");

                return true;
            }

            else
            {
                Console.Write("es el turno del jugador" + token.Player);

                return false;
            }

          
        }
    }
}
