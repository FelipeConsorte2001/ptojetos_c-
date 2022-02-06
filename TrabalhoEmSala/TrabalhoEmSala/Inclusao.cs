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
    public partial class Inclusao : Form
    {
        SqlConnection conexao =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Inclusao()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "insert into TBclientes (cpf,nome,endereco,cidade,telefoneDD,telefone) values('" + txtCpf.Text + "','" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtCidade.Text + "','" + txtDD.Text + "','" + txtTelefone.Text + "')";
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando sql" + ex.Message);

            }
        }

        private void Inclusao_Load(object sender, EventArgs e)
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

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            String cpf = txtCpf.Text;

            // txtEstado.Text = cpf.Substring(13);

            if (cpf.Substring(13) == "0")
            {
                txtEstado.Text = "Rio Grande do sul";
            } else if (cpf.Substring(13) == "1")
            {
                txtEstado.Text = "Distrito Federal, Goiás,Mato Grosso do Sul e Tocantins";
            }
            else if (cpf.Substring(13) == "2")
            {
                txtEstado.Text = "Amazonas, Pará, Roraima, Amapá, Acre e Rondónia";
            }
            else if (cpf.Substring(13) == "3")
            {
                txtEstado.Text = "Ceará, Maranhão e Piauí";
            }
            else if (cpf.Substring(13) == "4")
            {
                txtEstado.Text = "Paraíba, Pernambuco, Alagoas e Rio Grande do Norte";
            }
            else if (cpf.Substring(13) == "5")
            {
                txtEstado.Text = "Bahia e Sergipe";
            }
            else if (cpf.Substring(13) == "6")
            {
                txtEstado.Text = "Minas Gerais";
            }
            else if (cpf.Substring(13) == "7")
            {
                txtEstado.Text = "Rio de Janeiro e Espirito Santo";
            }
            else if (cpf.Substring(13) == "8")
            {
                txtEstado.Text = "São Paulo";
            }
            else if (cpf.Substring(13) == "9")
            {
                txtEstado.Text = "Paraná e Santa Catarina";
            }
            else if (cpf.Length < 14)
            {
                txtCpf.Text = "";
            }
        }
    }
}
