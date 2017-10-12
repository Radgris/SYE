using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{
    class Tablero
    {


        Casilla[] Board;

        Token PlayerA;
        Token PlayerB;
        Token currentPlayer;


 

        public Tablero()
        {


            Board = new Casilla[30];
            
            Board[0] = new Casilla(1, 0, 175, 700);
            Board[1] = new Casilla(2, 0, 310, 700);
            Board[2] = new Casilla(3, 21, 445, 700);
            Board[3] = new Casilla(4, 0, 580, 700);
            Board[4] = new Casilla(5, 7, 715, 700);
            Board[5] = new Casilla(6, 0, 850, 700);
            Board[6] = new Casilla(7, 0, 850, 550);
            Board[7] = new Casilla(8, 0, 715, 550);
            Board[8] = new Casilla(9, 0, 580, 550);
            Board[9] = new Casilla(10, 0, 445, 550);
            Board[10] = new Casilla(11, 25, 310, 550);
            Board[11] = new Casilla(12, 0, 175, 550);
            Board[12] = new Casilla(13, 0, 175, 400);
            Board[13] = new Casilla(14, 0, 310, 400);
            Board[14] = new Casilla(15, 0, 445, 400);
            Board[15] = new Casilla(16, 0, 580, 400);
            Board[16] = new Casilla(17, 3, 715, 400);
            Board[17] = new Casilla(18, 0, 850, 400);
            Board[18] = new Casilla(19, 6, 850, 250);
            Board[19] = new Casilla(20, 28, 715, 250);
            Board[20] = new Casilla(21, 8, 580, 250);
            Board[21] = new Casilla(22, 0, 445, 250);
            Board[22] = new Casilla(23, 0, 310, 250);
            Board[23] = new Casilla(24, 0, 175, 250);
            Board[24] = new Casilla(25, 0, 175, 100);
            Board[25] = new Casilla(26, 0, 310, 100);
            Board[26] = new Casilla(27, 1, 445, 100);
            Board[27] = new Casilla(28, 0, 580, 100);
            Board[28] = new Casilla(29, 0, 715, 100);
            Board[29] = new Casilla(30, 0, 850, 100);

            this.PlayerA = new Token(Board[0], "Jugador1");
      
            this.PlayerB = new Token(Board[0], "Jugador2");
            this.currentPlayer = this.PlayerA;




        }

        internal Casilla[] Board1 { get => Board; set => Board = value; }

        public Token CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        internal Token PlayerA1 { get => PlayerA; set => PlayerA = value; }
        internal Token PlayerB1 { get => PlayerB; set => PlayerB = value; }

    }








}
