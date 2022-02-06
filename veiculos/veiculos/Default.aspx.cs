using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace veiculos
{
    public partial class _Default : Page
    {
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\veiculo.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtFlex.Text.Trim() == "" || txtModelo.Text.Trim() == "" || txtValor.Text.Trim() == "" )
            {
                txtModelo.Focus();
                txtFlex.Focus();
                txtValor.Focus();
            }
            else
            {
                Caro caro = new Caro(txtModelo.Text, txtValor.Text, txtFlex.Text);
                String retorno = new CarroDAO().salvarCarro(caro);

                if(retorno == "OK")
                {
                    GridView1.DataBind();
                }
               
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (txtFlex.Text.Trim() == "" || txtModelo.Text.Trim() == "" || txtValor.Text.Trim() == "")
            {
                txtModelo.Focus();
                txtFlex.Focus();
                txtValor.Focus();
            }
            else
            {
                Caro caro = new Caro(txtModelo.Text, txtValor.Text, txtFlex.Text);
                String retorno = new CarroDAO().AtualiazaCaro(caro);
                if (retorno == "OK")
                {
                    GridView1.DataBind();
                }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text.Trim() == "")
            {
                txtModelo.Focus();
                txtFlex.Focus();
                txtValor.Focus();

            }
            else
            {
                Caro caro = new Caro(txtModelo.Text, txtValor.Text, txtFlex.Text);
                String retorno = new CarroDAO().ExcluirCaro(caro);
                if (retorno == "OK")
                {
                    GridView1.DataBind();
                }
            }
        }
    }
}