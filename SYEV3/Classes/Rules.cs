using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
      class Rules
    {




         public  static int CheckWinner(Token token)
        {

            if (token.Casilla.Numero >= 30)
            {
                
                Console.Write(token.Player + "ah ganado el juego");

                return 1;
            }

            else
            {
                Console.Write("es el turno del jugador" + token.Player);

                return 0;
            }

          
        }
    }
}
