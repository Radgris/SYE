﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYEV3.Classes;
using SYEV3;

namespace SYEV3
{
    public partial class Form1 : Form
    {

        Tablero BoardForm;

        

        public Form1()
        {
            InitializeComponent();
             BoardForm = new Tablero();
            

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();

            labelCasillaX.Text = (e.X / 135).ToString();
            labelCasillaY.Text = (e.Y / 150).ToString();
        }

        private void button1_Click( object sender, EventArgs e)
        {
            
            int tempdice=Dice.GetDice();
            labelDIce.Text = tempdice.ToString();

            int CasillaAMover = BoardForm.CurrentPlayer.Casilla.Numero + tempdice;
            Console.WriteLine(BoardForm.CurrentPlayer.Casilla.XLocation1);

            if (Rules.CheckWinner(BoardForm.CurrentPlayer))
            {

            }
            else
            {
                BoardForm.CurrentPlayer.Casilla = BoardForm.Board1[CasillaAMover];
                int casillaValueX = BoardForm.CurrentPlayer.Casilla.XLocation1;
                int casillaValueY = BoardForm.CurrentPlayer.Casilla.Ylocation1;
                pictureBox3.Left = casillaValueX;
                pictureBox3.Top = casillaValueY;
            }




        }
    }
}
