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
    public partial class Form_cadProduto : Form
    {
        public Form_cadProduto()
        {
            InitializeComponent();
        }

        private void Form_Produto_Load(object sender, EventArgs e)
        {

        }

        private void lblCadClie_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriarProd_Click(object sender, EventArgs e)
        {
            if (txtNomeProd.Text.Equals("") || txtIdProd.Text.Equals("") || txtEstoqueProd.Text.Equals("") ||
                txtPrecoPord.Text.Equals("") || txtProdDesc.Text.Equals("") )
            {
                MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            Form_listProduto form = new Form_listProduto();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
