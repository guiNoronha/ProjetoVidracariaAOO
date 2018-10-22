using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVidracariaAOO
{
    public partial class Form_cadCliente : Form
    {
        public Form_cadCliente()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text.Equals("") || txtCpfCli.Text.Equals("") || txtTelCli.Text.Equals("") ||
                txtCepCli.Text.Equals("") || txtBairroCli.Text.Equals("") || txtRuaCli.Text.Equals("") ||
                txtNroCli.Text.Equals("") || txtEmailCli.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
