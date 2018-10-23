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
    public partial class Form_listVisitas : Form
    {
        public Form_listVisitas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novaVisita_Click(object sender, EventArgs e)
        {
            Form_CadVisita novaVisita = new Form_CadVisita();
            novaVisita.StartPosition = FormStartPosition.CenterParent;
            novaVisita.ShowDialog(this);
        }
    }
}
