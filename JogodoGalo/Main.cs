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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Galo = new Form1();

            Galo.MdiParent = this;

            Galo.Show();



        }
    }
}
