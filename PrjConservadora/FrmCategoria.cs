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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtid.Clear();
            txtdescricao.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.Descricao_categoria = txtdescricao.Text;

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new CategoriaBLL().Cadastrar(categoria);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        categoria.Id_categoria = Convert.ToInt32(txtid.Text);
                        new CategoriaBLL().Update(categoria);
                        LimparCampos();
                    }
                }

                dtgCategoria.DataSource = new CategoriaBLL().Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            dtgCategoria.DataSource = new CategoriaBLL().Listar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Categoria categoria = new Categoria();
                        categoria.Id_categoria = Convert.ToInt32(txtid.Text);
                        new CategoriaBLL().Excluir(categoria);
                        LimparCampos();
                        dtgCategoria.DataSource = new CategoriaBLL().Listar();
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

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
