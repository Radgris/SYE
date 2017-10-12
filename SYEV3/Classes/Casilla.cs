using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYEV3.Classes
{


    class Casilla
    {
        byte numero;
        byte especial;
        int XLocation;
        int Ylocation;

        public Casilla(byte numero, byte especial, int xLocation, int ylocation)
        {
            this.numero = numero;
            this.especial = especial;
            this.XLocation = xLocation;
            this.Ylocation = ylocation;


        }

        public byte Numero { get => numero; set => numero = value; }
        public byte Especial { get => especial; set => especial = value; }
        public int XLocation1 { get => XLocation; set => XLocation = value; }
        public int Ylocation1 { get => Ylocation; set => Ylocation = value; }
    }

}
