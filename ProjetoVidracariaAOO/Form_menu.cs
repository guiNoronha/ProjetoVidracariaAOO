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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_listVisitas visitas = new Form_listVisitas();
            visitas.StartPosition = FormStartPosition.CenterParent;
            visitas.ShowDialog(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login form = new Form_login();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form_cadCliente form = new Form_cadCliente();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Form_cadFornecedor form = new Form_cadFornecedor();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
