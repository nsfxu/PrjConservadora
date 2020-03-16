namespace PrjConservadora
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsair = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(550, 480);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 43);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(154, 480);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(116, 43);
            this.btninserir.TabIndex = 6;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(121, 441);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(221, 20);
            this.txtcpf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(429, 400);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(221, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(121, 397);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 20);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sobrenome:";
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(429, 355);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(221, 20);
            this.txtsobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(121, 355);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(221, 20);
            this.txtnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(57, 12);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(691, 281);
            this.dtgCliente.TabIndex = 21;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(121, 315);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(66, 20);
            this.txtid.TabIndex = 0;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(208, 315);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "Form1";
            this.Text = "Conservadora - Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
    }
}

