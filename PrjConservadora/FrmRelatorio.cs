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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            dtgclientes.DataSource = new Usuario().ListarCliente();
            dtgprestadores.DataSource = new Usuario().ListarPrestador();
            dtgservicos.DataSource = new Usuario().ListarServicos();
            // dtgresumitivo.DataSource = new Usuario().ListarResumitivo();
        }
    }
}
