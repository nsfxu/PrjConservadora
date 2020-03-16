using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace PrjConservadora
{
    public partial class FrmPrestador : Form
    {
        public FrmPrestador()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtid.Clear();
            txtnome.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txtsobrenome.Clear();
            txtsenha.Clear();
            txtcategoriaID.Clear();
            txtvip.Clear();
        }

        private void FrmPrestador_Load(object sender, EventArgs e)
        {
            dtgPrestador.DataSource = new PrestadorBLL().Listar();
            dtgCategoria.DataSource = new CategoriaBLL().Listar();

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                Prestador prestador = new Prestador();
                prestador.Nome_prestador= txtnome.Text;
                prestador.Sobrenome_prestador = txtsobrenome.Text;
                prestador.Email_prestador = txtemail.Text;
                prestador.Senha_prestador = txtsenha.Text;
                prestador.Cpf_prestador = txtcpf.Text;
                prestador.Tbl_categoria_id_categoria = Convert.ToInt32(txtcategoriaID.Text);
                prestador.Vip_prestador = Convert.ToInt32(txtvip.Text);

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new PrestadorBLL().Cadastrar(prestador);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        prestador.Id_prestador = Convert.ToInt32(txtid.Text);
                        new PrestadorBLL().Update(prestador);
                        LimparCampos();
                    }
                }

                dtgPrestador.DataSource = new PrestadorBLL().Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Prestador prestador = new Prestador();
                        prestador.Id_prestador = Convert.ToInt32(txtid.Text);
                        new PrestadorBLL().Excluir(prestador);
                        LimparCampos();
                        dtgPrestador.DataSource = new PrestadorBLL().Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Favor selecionar o registro a ser deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
