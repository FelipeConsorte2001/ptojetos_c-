using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aulaweb2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Pagina2.aspx?Nome=" +
             txtNome.Text + "&Sexo=" +
             rblSexo.SelectedValue + "&Estados=" +
             ddlEstados.SelectedValue +
             "&Confirma=" + ckbConfirma.Text);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}