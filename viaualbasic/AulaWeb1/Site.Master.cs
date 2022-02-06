using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AulaWeb1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Produtos> listaProdutos = new List<Produtos>();
                Session["produtos"] = listaProdutos;
            }
        }
        protected void LimparCampos()
        {
            txtCodigoProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
        }
        protected void btnSalvar(object sender, EventArgs e)
        {
            List<Produtos> listaProdutos = (List<Produtos>)Session["produtos"];
            Produtos objProduto = new Produtos();
            objProduto.Id = txtCodigoProduto.Text;
            objProduto.Nome = txtNomeProduto.Text;
            objProduto.Valor = Convert.ToDecimal(txtValorProduto.Text);
            listaProdutos.Add(objProduto);
            gdvProdutos.DataSource = listaProdutos;
            gdvProdutos.DataBind();
            LimparCampos();
        }
        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            List<Produtos> listaProdutos = (List<Produtos>)Session["produtos"];
            foreach (Produtos objProduto in listaProdutos)
            {
                if (objProduto.Id == txtCodigoProduto.Text)
                {
                    objProduto.Nome = txtNomeProduto.Text;
                    objProduto.Valor = Convert.ToDecimal(txtValorProduto.Text);
                }
            }
            gdvProdutos.DataSource = listaProdutos;
            gdvProdutos.DataBind();
            LimparCampos();
        }
        protected void btnRemover_Click(object sender, EventArgs e)
        {
            List<Produtos> listaProdutos = (List<Produtos>)Session["produtos"];
            Produtos objProduto = null;
            foreach (Produtos item in listaProdutos)
            {
                if (item.Id == txtCodigoProduto.Text)
                {
                    objProduto = item;
                }
            }
            //Para removermos um item da lista é necessário pegar a referência
            //de um dos objetos que compoem a lista
            listaProdutos.Remove(objProduto);
            gdvProdutos.DataSource = listaProdutos;
            gdvProdutos.DataBind();
            LimparCampos();
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Produtos> listaProdutos = (List<Produtos>)Session["produtos"];
            foreach (Produtos item in listaProdutos)
            {
                if (item.Id == txtCodigoProduto.Text)
                {
                    txtNomeProduto.Text = item.Nome;
                    txtValorProduto.Text = item.Valor.ToString();
                }
            }
        }

    }
}