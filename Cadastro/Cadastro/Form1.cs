using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new
            SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Aula.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "insert into alunos ( id,nome,curso) values (  " + txtId.Text + ", '" + txtNome.Text + "','" + txtCurso.Text + "')";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    MessageBox.Show("Cadastro efetuado");
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado");
                }
                txtCurso.Text = "";
                txtId.Text = "";
                txtNome.Text = "";
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando sql" + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "insert into alunos ( id,nome,curso) values (  " + txtId.Text + ", '" + txtNome.Text + "','" + txtCurso.Text + "')";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    MessageBox.Show("Cadastro efetuado");
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado");
                }
                txtCurso.Text = "";
                txtId.Text = "";
                txtNome.Text = "";
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando sql" + ex.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            from2 f2 = new from2();
            f2.Show();
        }
    }
}
