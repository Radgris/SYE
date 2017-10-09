using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
    class Token
    {

        Casilla casilla;

        string player;

        


        public void move(byte casillasAMover, Tablero Board)
        {  
            
            casilla = Board.Board1[casilla.Numero + (casillasAMover)];            

        }
    }
}
