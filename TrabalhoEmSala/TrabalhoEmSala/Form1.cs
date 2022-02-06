using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEmSala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inclusao inclusao;
            inclusao = new Inclusao();
            inclusao.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consulta;
            consulta = new Consulta();
            consulta.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre sobre;
            sobre = new Sobre();
            sobre.Show();
        }
    }
}
