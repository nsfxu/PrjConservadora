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
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtid.Clear();
            txtdescricao.Clear();
            txtvalorvip.Clear();
            txtvalorhora.Clear();
            txtminimohora.Clear();
            txtcategoriaID.Clear();
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            dtgServico.DataSource = new ServicosBLL().Listar();
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
                        Servicos servicos = new Servicos();
                        servicos.Id_servico = Convert.ToInt32(txtid.Text);
                        new ServicosBLL().Excluir(servicos);
                        LimparCampos();
                        dtgServico.DataSource = new ServicosBLL().Listar();
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

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                Servicos servicos = new Servicos();
                servicos.Descricao_servico = txtdescricao.Text;
                servicos.Valorhora_servico = Convert.ToDouble(txtvalorhora.Text);
                servicos.Valorhoravip_servico = Convert.ToDouble(txtvalorvip.Text);
                servicos.Minimohora_servico = Convert.ToInt32(txtminimohora.Text);
                servicos.Tbl_categoria_id_categoria = Convert.ToInt32(txtcategoriaID.Text);

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new ServicosBLL().Cadastrar(servicos);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        servicos.Id_servico = Convert.ToInt32(txtid.Text);
                        new ServicosBLL().Update(servicos);
                        LimparCampos();
                    }
                }

                dtgServico.DataSource = new ServicosBLL().Listar();
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
