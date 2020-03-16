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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Usuario dao = new Usuario();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (dao.Validar(txtemail.Text, txtsenha.Text) != -1)
            {
                this.Hide();
                if (Globais.tipo == "Prestador")
                {
                    var FrmPrest = new FrmPrest();
                    FrmPrest.Closed += (s, args) => this.Close();
                    FrmPrest.Show();
                }
                else if(Globais.tipo == "Atendente")
                {
                    var FrmAtendente = new FrmAtendente();
                    FrmAtendente.Closed += (s, args) => this.Close();
                    FrmAtendente.Show();
                }
                else if (Globais.tipo == "Gerente")
                {
                    var FrmMenu = new FrmMenu();
                    FrmMenu.Closed += (s, args) => this.Close();
                    FrmMenu.Show();
                }

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!!");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
public static class Globais
{
    public static string tipo;
    public static string nome;
    public static int id;

}
