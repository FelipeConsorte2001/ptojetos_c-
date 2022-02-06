using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resposta;
            //Armazenamento da resposta do utilizador na MessageBox
            //Botão Yes - Valor 6
            //Botão No - Valor 7
            //Botão Cancelar - Valor 2

            resposta = Convert.ToInt32(MessageBox.Show("Pretende continuar?",
            "Mensagem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
            //Avaliação da resposta dada
            if (resposta == 6)
                MessageBox.Show("Carregou em Sim", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            else
                if (resposta == 7)
                MessageBox.Show("Carregou em Não", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            else
                    if (resposta == 2)
                MessageBox.Show("Carregou em Cancelar", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);



            string message = "Pretende Continuar?";
            string caption = "Decisão";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                MessageBox.Show("Carregou em Sim", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                this.Close();

            }
        }
    }
}
