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
    public partial class Form_cadFornecedor : Form
    {
        public Form_cadFornecedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_cadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomeForn.Text.Equals("") || txtCnpjForn.Text.Equals("") || txtTelForn.Text.Equals("") ||
                txtCepForn.Text.Equals("") || txtBairroForn.Text.Equals("") || txtRuaForn.Text.Equals("") ||
                txtNroForn.Text.Equals("") || txtEmailForn.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
