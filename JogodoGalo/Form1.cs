using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JogodoGalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string jogada = "X";

        private void Pos1_Click(object sender, EventArgs e)
        {

            if(Pos1.Text == "X" || Pos1.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if(jogada == "X")
                {
                    Pos1.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if(jogada == "O")
                {
                    Pos1.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }

        }

        private void Pos2_Click(object sender, EventArgs e)
        {
            if (Pos2.Text == "X" || Pos2.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos2.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos2.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos3_Click(object sender, EventArgs e)
        {
            if (Pos3.Text == "X" || Pos3.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos3.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos3.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos4_Click(object sender, EventArgs e)
        {
            if (Pos4.Text == "X" || Pos4.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos4.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos4.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos5_Click(object sender, EventArgs e)
        {
            if (Pos5.Text == "X" || Pos5.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos5.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos5.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos6_Click(object sender, EventArgs e)
        {
            if (Pos6.Text == "X" || Pos6.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos6.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos6.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos7_Click(object sender, EventArgs e)
        {
            if (Pos7.Text == "X" || Pos7.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos7.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos7.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos8_Click(object sender, EventArgs e)
        {
            if (Pos8.Text == "X" || Pos8.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos8.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos8.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        private void Pos9_Click(object sender, EventArgs e)
        {
            if (Pos9.Text == "X" || Pos9.Text == "O")
            {
                MessageBox.Show("Está Ocupada");
            }
            else
            {
                if (jogada == "X")
                {
                    Pos9.Text = "X";
                    Vitoria(jogada);
                    jogada = "O";
                }
                else if (jogada == "O")
                {
                    Pos9.Text = "O";
                    Vitoria(jogada);
                    jogada = "X";
                }
            }
        }

        public void Vitoria(string vitoria)
        {
            //Horizontal
            if(Pos1.Text == vitoria && Pos2.Text == vitoria && Pos3.Text == vitoria)
            {
                if(vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            if (Pos4.Text == vitoria && Pos5.Text == vitoria && Pos6.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            if (Pos7.Text == vitoria && Pos8.Text == vitoria && Pos9.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            //Vertical

            if (Pos1.Text == vitoria && Pos4.Text == vitoria && Pos7.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            if (Pos2.Text == vitoria && Pos5.Text == vitoria && Pos8.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            if (Pos3.Text == vitoria && Pos6.Text == vitoria && Pos9.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            //diagonal

            if (Pos1.Text == vitoria && Pos5.Text == vitoria && Pos9.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            if (Pos3.Text == vitoria && Pos5.Text == vitoria && Pos6.Text == vitoria)
            {
                if (vitoria == "X")
                {
                    MessageBox.Show("Jogador 1 ganhou!!!");
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou!!!");
                }
            }

            //empate

            if(Pos1.Text != "" && Pos2.Text != "" && Pos3.Text != "" && Pos4.Text != "" && Pos5.Text != "" && Pos6.Text != "" && Pos7.Text != "" && Pos8.Text != "" && Pos9.Text != "")
            {
                MessageBox.Show("Empate!!!!!!");
            }

        }


    }

}
