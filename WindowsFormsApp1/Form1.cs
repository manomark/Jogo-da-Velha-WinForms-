using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int jogador = 1, jogadas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void vencedor()
        {
            if (((btna1.Text == btnb1.Text && btna1.Text == btnc1.Text) || (btna1.Text == btnb2.Text && btna1.Text == btnc3.Text) || (btna1.Text == btna2.Text && btna1.Text == btna3.Text)) && btna1.Text != "")
            {
                msg_Winner.Text = btna1.Text;
                btna1.Text = "";
                btna2.Text = "";
                btna3.Text = "";
                btnb1.Text = "";
                btnb2.Text = "";
                btnb3.Text = "";
                btnc1.Text = "";
                btnc2.Text = "";
                btnc3.Text = "";

            }
            else if (((btnb2.Text == btnb1.Text && btnb2.Text == btnb3.Text) || (btnb2.Text == btna3.Text && btnb2.Text == btnc1.Text) || (btnb2.Text == btna2.Text && btnb2.Text == btnc2.Text)) && btnb2.Text != "")
            {
                msg_Winner.Text = btnb2.Text;
                btna1.Text = "";
                btna2.Text = "";
                btna3.Text = "";
                btnb1.Text = "";
                btnb2.Text = "";
                btnb3.Text = "";
                btnc1.Text = "";
                btnc2.Text = "";
                btnc3.Text = "";


            }
            else if (((btnc3.Text == btnc1.Text && btnc3.Text == btnc2.Text) || (btnc3.Text == btnb2.Text && btnc3.Text == btna1.Text) || (btnc3.Text == btnb3.Text && btnc3.Text == btna3.Text)) && btnc3.Text != "")
            {
                msg_Winner.Text = btnc3.Text;
                btna1.Text = "";
                btna2.Text = "";
                btna3.Text = "";
                btnb1.Text = "";
                btnb2.Text = "";
                btnb3.Text = "";
                btnc1.Text = "";
                btnc2.Text = "";
                btnc3.Text = "";
            }
            else if (jogadas >=9)
            {
                btna1.Text = "";
                btna2.Text = "";
                btna3.Text = "";
                btnb1.Text = "";
                btnb2.Text = "";
                btnb3.Text = "";
                btnc1.Text = "";
                btnc2.Text = "";
                btnc3.Text = "";
                jogadas = 0;
            }
            
        }
        private void btna2_Click(object sender, EventArgs e)
        {
            if (btna2.Text == "")
            {
                if (jogador == 1)
                {
                    btna2.Text = "X";
                }
                else
                {
                    btna2.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btna3_Click(object sender, EventArgs e)
        {
            if (btna3.Text == "")
            {
                if (jogador == 1)
                {
                    btna3.Text = "X";
                }
                else
                {
                    btna3.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnb1_Click(object sender, EventArgs e)
        {
            if (btnb1.Text == "")
            {
                if (jogador == 1)
                {
                    btnb1.Text = "X";
                }
                else
                {
                    btnb1.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnb2_Click(object sender, EventArgs e)
        {
            if (btnb2.Text == "")
            {
                if (jogador == 1)
                {
                    btnb2.Text = "X";
                }
                else
                {
                    btnb2.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnb3_Click(object sender, EventArgs e)
        {
            if (btnb3.Text == "")
            {
                if (jogador == 1)
                {
                    btnb3.Text = "X";
                }
                else
                {
                    btnb3.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            if (btnc1.Text == "")
            {
                if (jogador == 1)
                {
                    btnc1.Text = "X";
                }
                else
                {
                    btnc1.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnc2_Click(object sender, EventArgs e)
        {
            if (btnc2.Text == "")
            {
                if (jogador == 1)
                {
                    btnc2.Text = "X";
                }
                else
                {
                    btnc2.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void btnc3_Click(object sender, EventArgs e)
        {
            if (btnc3.Text == "")
            {
                if (jogador == 1)
                {
                    btnc3.Text = "X";
                }
                else
                {
                    btnc3.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }

        private void msg_Winner_Click(object sender, EventArgs e)
        {

        }

        private void btna1_Click(object sender, EventArgs e)
        {
            if (btna1.Text == "") {
                if (jogador == 1) {
                    btna1.Text = "X";
                }else {
                    btna1.Text = "O";
                }
                jogadas++;
                vencedor();
                jogador = jogador * -1;
            }
        }
    }
}
