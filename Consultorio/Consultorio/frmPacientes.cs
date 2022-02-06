using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pacienteDataSet.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.pacienteDataSet.Pacientes);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "   ,   ,   -")
            {
                MessageBox.Show("Cpf com preenchimento Obrigatório");
                txtCpf.Focus();
            }
            else if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome com preenchimento Obrigatório");
                txtNome.Focus();
            }
            else if (txtNascimento.Text == "  /  /")
            {
                MessageBox.Show("Nascimento com preenchimento Obrigatório");
                txtNascimento.Focus();
            }
            else if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("Endereço com preenchimento Obrigatório");
                txtEndereco.Focus();
            }
            else
            {

                this.pacientesTableAdapter.InsertPaciente(
                    txtCpf.Text, txtNome.Text,
                    txtNascimento.Text, txtEndereco.Text
                    );

                this.pacientesTableAdapter.
                Fill(this.pacienteDataSet.Pacientes);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtCpf.Text == "   ,   ,   -")
            {
                MessageBox.Show("Cpf com preenchimento Obrigatório");
                txtCpf.Focus();
            }
            else if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome com preenchimento Obrigatório");
                txtNome.Focus();
            }
            else if (txtNascimento.Text == "  /  /")
            {
                MessageBox.Show("Nascimento com preenchimento Obrigatório");
                txtNascimento.Focus();
            }
            else if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("Endereço com preenchimento Obrigatório");
                txtEndereco.Focus();
            }
            else
            {

                this.pacientesTableAdapter.AlterarPacientes(
                    txtCpf.Text, txtNome.Text,
                    txtNascimento.Text, txtEndereco.Text
                    );

                this.pacientesTableAdapter.
                Fill(this.pacienteDataSet.Pacientes);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.pacientesTableAdapter.ExcluirPaciente(txtCpf.Text);
            this.pacientesTableAdapter.
            Fill(this.pacienteDataSet.Pacientes);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
