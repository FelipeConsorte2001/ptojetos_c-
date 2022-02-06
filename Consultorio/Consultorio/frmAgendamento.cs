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
    public partial class frmAgendamento : Form
    {
        public object AgendamentoTableAdapter { get; private set; }

        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendamentoDataSet.Agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter1.Fill(this.agendamentoDataSet.Agendamento);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "   ,   ,   -")
            {
                MessageBox.Show("Cpf com preenchimento Obrigatório");
                txtCpf.Focus();
            }
            else if (txtHora.Text == "  -  ")
            {
                MessageBox.Show("Nome com preenchimento Obrigatório");
                txtHora.Focus();
            }
            else if (txtData.Text == "  /  /")
            {
                MessageBox.Show("Data com preenchimento Obrigatório");
                txtData.Focus();
            }
            else if (txtProcedimento.Text.Trim() == "")
            {
                MessageBox.Show("Endereço com preenchimento Obrigatório");
                txtProcedimento.Focus();
            }
            else
            {
                this.agendamentoTableAdapter1.inseriAgenda(
                    txtCpf.Text, txtHora.Text,
                    txtData.Text, txtProcedimento.Text
                    );

                this.agendamentoTableAdapter1.
                Fill(this.agendamentoDataSet.Agendamento);
            }
        }
    }
}
