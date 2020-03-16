using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConservadora
{
    public partial class FrmAtendente : Form
    {
        public FrmAtendente()
        {
            InitializeComponent();
        }

        private void FrmAtendente_Load(object sender, EventArgs e)
        {
            label1.Text = "Seja bem vindo(a) " + Globais.nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxescolha.Text == "Cliente")
            {
                FrmCliente x = new FrmCliente();
                x.Show();
            }
            else if (cbxescolha.Text == "Os")
            {
                FrmOs x = new FrmOs();
                x.Show();
            }
            else
            {
                MessageBox.Show("Escolha um opção!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
