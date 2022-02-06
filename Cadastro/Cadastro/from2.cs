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
    public partial class from2 : Form
    {
        SqlConnection conexao = new
           SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Aula.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public from2()
        {
            InitializeComponent();
        }

        private void from2_Load(object sender, EventArgs e)
        {

        }
    }
}
