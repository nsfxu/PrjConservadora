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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxescolha.Text == "Avaliacao")
            {
                FrmAvaliacao x = new FrmAvaliacao();
                x.Show();
            }
            else if (cbxescolha.Text == "Categoria")
            {
                FrmCategoria x = new FrmCategoria();
                x.Show();
            }
            else if (cbxescolha.Text == "Cliente")
            {
                FrmCliente x = new FrmCliente();
                x.Show();
            }
            else if (cbxescolha.Text == "Os")
            {
                FrmOs x = new FrmOs();
                x.Show();
            }
            else if (cbxescolha.Text == "Prestador")
            {
                FrmPrestador x = new FrmPrestador();
                x.Show();
            }
            else if (cbxescolha.Text == "Servicos")
            {
                FrmServicos x = new FrmServicos();
                x.Show();
            }
            else
            {
                MessageBox.Show("Escolha um opção!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label3.Text = "Seja bem vindo(a) " + Globais.nome;
        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio x = new FrmRelatorio();
            x.Show();
        }
    }
}
