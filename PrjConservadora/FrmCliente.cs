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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
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
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome_cliente = txtnome.Text;
                cliente.Sobrenome_cliente = txtsobrenome.Text;
                cliente.Email_cliente = txtemail.Text;
                cliente.Senha_cliente = txtsenha.Text;
                cliente.Cpf_cliente = txtcpf.Text;

                if (txtid.Text.Equals(string.Empty))
                {
                    if (MessageBox.Show("Está ação irá adicionar um novo registro em banco de dados, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        new ClienteBLL().Cadastrar(cliente);
                        LimparCampos();
                    }
                }
                else
                {
                    if (MessageBox.Show("Está ação irá alterar os dados do registro selecionado, deseja continuar?", "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        cliente.Id_cliente = Convert.ToInt32(txtid.Text);
                        new ClienteBLL().Update(cliente);
                        LimparCampos();
                    }
                }

                dtgCliente.DataSource = new ClienteBLL().Listar();
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
                        Cliente cliente = new Cliente();
                        cliente.Id_cliente = Convert.ToInt32(txtid.Text);
                        new ClienteBLL().Excluir(cliente);
                        LimparCampos();
                        dtgCliente.DataSource = new ClienteBLL().Listar();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = new ClienteBLL().Listar();
        }
    }
}
