using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PrjConservadora
{
    public partial class FrmAvaliacao : Form
    {
        public FrmAvaliacao()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtid.Clear();
            txtnota.Clear();
            txtprestadorID.Clear();
            txtcomentario.Clear();
            txtclienteID.Clear();
        }

        private void FrmAvaliacao_Load(object sender, EventArgs e)
        {
            dtgPrestador.DataSource = new PrestadorBLL().Listar();
            dtgCliente.DataSource = new ClienteBLL().Listar();
            dtgAvaliacao.DataSource = new AvaliacaoBLL().Listar();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Avaliacao avaliacao = new Avaliacao();
                        avaliacao.Id_avaliacao = Convert.ToInt32(txtid.Text);
                        new AvaliacaoBLL().Excluir(avaliacao);
                        LimparCampos();
                        dtgAvaliacao.DataSource = new AvaliacaoBLL().Listar();
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
                Avaliacao avaliacao = new Avaliacao();
                avaliacao.Nota_avaliacao = Convert.ToInt32(txtnota.Text);
                avaliacao.Comentario_avaliacao = txtcomentario.Text;
                avaliacao.Tbl_cliente_id_cliente = Convert.ToInt32(txtclienteID.Text);
                avaliacao.Tbl_prestador_id_prestador = Convert.ToInt32(txtprestadorID.Text);

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new AvaliacaoBLL().Cadastrar(avaliacao);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        avaliacao.Id_avaliacao = Convert.ToInt32(txtid.Text);
                        new AvaliacaoBLL().Update(avaliacao);
                        LimparCampos();
                    }
                }
                dtgAvaliacao.DataSource = new AvaliacaoBLL().Listar();
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
