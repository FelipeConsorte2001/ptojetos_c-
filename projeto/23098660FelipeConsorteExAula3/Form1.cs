using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23098660FelipeConsorteExAula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void assuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assunto assunto = new Assunto();
            assunto.MDIParent = true;
            assunto.Show();

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros();
            livro.MDIParent = true;
            livro.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.MDIParent = true;
            sobre.Show();
        }
    }
}
