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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtRegistro.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Certifique que os campos estão preenchidos!", "Aviso!", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Form_menu form = new Form_menu();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                Close();
            }
        }
    }
}
