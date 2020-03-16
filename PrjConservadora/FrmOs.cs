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
    public partial class FrmOs : Form
    {
        public FrmOs()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtid.Clear();
            txtcep.Clear();
            txtcliente.Clear();
            txtcomentario.Clear();  
            txtcomplemento.Clear();
            txtdescricao.Clear();
            txthorascontratadas.Clear();
            txtnumeroendereco.Clear();
            txtprestador.Clear();
            txtstatus.Clear();
            txtservico.Clear();
            txtvip.Clear();
            dtpservico.Value = DateTime.Now;
            dtpabertura.Value = DateTime.Now;
        }

        private void FrmOs_Load(object sender, EventArgs e)
        {
            dtgPrestador.DataSource = new PrestadorBLL().Listar();
            dtgCliente.DataSource = new ClienteBLL().Listar();
            dtgServico.DataSource = new ServicosBLL().Listar();
            dtgOs.DataSource = new OsBLL().Listar();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                Os os = new Os();
                os.Dataabertura_os = dtpservico.Value.ToString("yyyy/MM/dd");
                os.Dataservico_os = dtpabertura.Value.ToString("yyyy/MM/dd");
                os.Cep_os = txtcep.Text;
                os.Numendereco_os = Convert.ToInt32(txtnumeroendereco.Text);
                os.Complemento_os = txtcomplemento.Text;
                os.Vip_os = Convert.ToInt32(txtvip.Text);
                os.Horacontratadas_os = Convert.ToInt32(txthorascontratadas.Text);
                os.Descricao_os = txtdescricao.Text;
                os.Comentarios_os = txtcomentario.Text;
                os.Status_os = Convert.ToInt32(txtstatus.Text);
                os.Tbl_servicos_id_servico = Convert.ToInt32(txtservico.Text);
                os.Tbl_cliente_id_cliente = Convert.ToInt32(txtcliente.Text);
                os.Tbl_prestador_id_prestador = Convert.ToInt32(txtprestador.Text);
                

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new OsBLL().Cadastrar(os);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        os.Id_os = Convert.ToInt32(txtid.Text);
                        new OsBLL().Update(os);
                        LimparCampos();
                    }
                }
                dtgOs.DataSource = new OsBLL().Listar();
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

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Os os = new Os();
                        os.Id_os = Convert.ToInt32(txtid.Text);
                        new OsBLL().Excluir(os);
                        LimparCampos();
                        dtgOs.DataSource = new OsBLL().Listar();
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

        private void txthorascontratadas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
