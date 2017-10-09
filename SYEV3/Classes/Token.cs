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

        String player;

        public Token(Casilla casilla, string player)
        {
            this.casilla = casilla;
            this.player = player;
        }

        public string Player { get => player; set => player = value; }
        internal Casilla Casilla { get => casilla; set => casilla = value; }

        public void move(byte casillasAMover, Tablero Board)
        {  
            
            casilla = Board.Board1[casilla.Numero + (casillasAMover)]; 
            
            if(casilla.Especial != 0)
            { casilla = Board.Board1[casilla.Especial]; }

        }
    }
}
