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
    public partial class FrmPrest : Form
    {
        public FrmPrest()
        {
            InitializeComponent();
        }

        private void FrmPrest_Load(object sender, EventArgs e)
        {
            label1.Text = "Seja bem vindo(a) " + Globais.nome;
            dataGridView1.DataSource = new PrestadorBLL().ListarWhere("tbl_prestador_id_prestador =" + Globais.id);

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

        private void btnfechar_Click(object sender, EventArgs e)
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
                os.Status_os = 1;
                os.Tbl_servicos_id_servico = Convert.ToInt32(txtservico.Text);
                os.Tbl_cliente_id_cliente = Convert.ToInt32(txtcliente.Text);
                os.Tbl_prestador_id_prestador = Convert.ToInt32(txtprestador.Text);
                os.Id_os = Convert.ToInt32(txtid.Text);
                LimparCampos();                 
             
                dataGridView1.DataSource = new PrestadorBLL().ListarWhere("tbl_prestador_id_prestador =" + Globais.id);
                MessageBox.Show("Chamado fechado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpabertura.Text = dataGridView1.Rows[e.RowIndex].Cells["dataabertura_os"].Value.ToString();
            dtpservico.Text = dataGridView1.Rows[e.RowIndex].Cells["dataservico_os"].Value.ToString();
            txtcep.Text = dataGridView1.Rows[e.RowIndex].Cells["cep_os"].Value.ToString();
            txtnumeroendereco.Text = dataGridView1.Rows[e.RowIndex].Cells["numendereco_os"].Value.ToString();
            txtcomplemento.Text = dataGridView1.Rows[e.RowIndex].Cells["complemento_os"].Value.ToString();            
            txtvip.Text = dataGridView1.Rows[e.RowIndex].Cells["vip_os"].Value.ToString();
            if(txtvip.Text == "True")
            {
                txtvip.Text = "1";
            }
            else
            {
                txtvip.Text = "0";

            }
            txthorascontratadas.Text = dataGridView1.Rows[e.RowIndex].Cells["horacontratadas_os"].Value.ToString();
            txtdescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["descricao_os"].Value.ToString();
            txtcomentario.Text = dataGridView1.Rows[e.RowIndex].Cells["comentarios_os"].Value.ToString();
            txtservico.Text = dataGridView1.Rows[e.RowIndex].Cells["tbl_servicos_id_servico"].Value.ToString();
            txtcliente.Text = dataGridView1.Rows[e.RowIndex].Cells["tbl_cliente_id_cliente"].Value.ToString();
            txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells["status_os"].Value.ToString();
            if (txtstatus.Text == "True")
            {
                txtstatus.Text = "1";
            }
            else
            {
                txtstatus.Text = "0";

            }
            txtprestador.Text = dataGridView1.Rows[e.RowIndex].Cells["tbl_prestador_id_prestador"].Value.ToString();
        }
    }
}
