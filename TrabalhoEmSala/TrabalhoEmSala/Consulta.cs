using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrabalhoEmSala
{
    public partial class Consulta : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Consulta()
        {
            InitializeComponent();
        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inclusao inclusao;
            inclusao = new Inclusao();
            inclusao.Show();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.TBclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tBclientesTableAdapter.Fill(this.database1DataSet.TBclientes);
        }

        private void result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
