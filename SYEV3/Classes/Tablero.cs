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

        public Tablero()
        {
            Board = new Casilla[29];
            
            Board[0] = new Casilla(1, 0, 175, 700);
            Board[1] = new Casilla(2, 0, 12, 45);
            Board[2] = new Casilla(3, 21, 12, 45);
            Board[3] = new Casilla(4, 0, 12, 45);
            Board[4] = new Casilla(5, 7, 12, 45);
            Board[5] = new Casilla(6, 0, 12, 45);
            Board[6] = new Casilla(7, 0, 12, 45);
            Board[7] = new Casilla(8, 0, 12, 45);
            Board[8] = new Casilla(9, 0, 12, 45);
            Board[9] = new Casilla(10, 0, 12, 45);
            Board[10] = new Casilla(11, 25, 12, 45);
            Board[11] = new Casilla(12, 0, 12, 45);
            Board[12] = new Casilla(13, 0, 12, 45);
            Board[13] = new Casilla(14, 0, 12, 45);
            Board[14] = new Casilla(15, 0, 12, 45);
            Board[15] = new Casilla(16, 0, 12, 45);
            Board[16] = new Casilla(17, 3, 12, 45);
            Board[17] = new Casilla(18, 0, 12, 45);
            Board[18] = new Casilla(19, 6, 12, 45);
            Board[19] = new Casilla(20, 28, 12, 45);
            Board[20] = new Casilla(21, 8, 12, 45);
            Board[21] = new Casilla(22, 0, 12, 45);
            Board[22] = new Casilla(23, 0, 12, 45);
            Board[23] = new Casilla(24, 0, 12, 45);
            Board[24] = new Casilla(25, 0, 12, 45);
            Board[25] = new Casilla(26, 0, 12, 45);
            Board[26] = new Casilla(27, 1, 12, 45);
            Board[27] = new Casilla(28, 0, 12, 45);
            Board[28] = new Casilla(29, 0, 12, 45);
            Board[29] = new Casilla(30, 0, 12, 45);




        }

        internal Casilla[] Board1 { get => Board; set => Board = value; }
    }








}
