using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodoGalo
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();

            listBox1.DataSource = System.IO.File.ReadAllLines("jogo.txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
