using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebComBanco
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnIncluir_Click1(object sender, EventArgs e)
        {
            if (txtRGM.Text.Trim() == "")
            {
                lblMensagem.Text = "Preecha o RGM do aluno";
                txtRGM.Focus();
            }
            else if (txtNome.Text.Trim() == "")
            {
                lblMensagem.Text = "Preencha o nome do aluno";
                txtNome.Focus();
            }
            else if (txtNota1.Text.Trim() == "")
            {
                lblMensagem.Text = "Preencha a nota 1";
                txtNota1.Focus();
            }
            else if (txtNota2.Text.Trim() == "")
            {
                lblMensagem.Text = "Preencha a nota 2";
                txtNota2.Focus();
            }
            else
            {

                Aluno aluno = new Aluno(txtRGM.Text, txtNome.Text, float.Parse(txtNota1.Text), float.Parse(txtNota2.Text));
                String retorno = new AlunoDAO().salvarAluno(aluno);

                if (retorno == "OK")
                {
                    lblMensagem.Text = "Sucesso na inserção";
                    GridView1.DataBind();
                }
                else
                {
                    lblMensagem.Text = retorno;
                }

            }
        }
    }
}