namespace PrjConservadora
{
    partial class FrmAvaliacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsair = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgAvaliacao = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclienteID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprestadorID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPrestador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAvaliacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(592, 507);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 43);
            this.btnsair.TabIndex = 46;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(61, 507);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(116, 43);
            this.btninserir.TabIndex = 45;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID:";
            // 
            // dtgAvaliacao
            // 
            this.dtgAvaliacao.AllowUserToAddRows = false;
            this.dtgAvaliacao.AllowUserToDeleteRows = false;
            this.dtgAvaliacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAvaliacao.Location = new System.Drawing.Point(38, 12);
            this.dtgAvaliacao.Name = "dtgAvaliacao";
            this.dtgAvaliacao.Size = new System.Drawing.Size(940, 281);
            this.dtgAvaliacao.TabIndex = 48;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 318);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(66, 20);
            this.txtid.TabIndex = 43;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(185, 318);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 47;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nota:";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(98, 349);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(296, 20);
            this.txtnota.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Comentário:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(98, 382);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(296, 20);
            this.txtcomentario.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cliente ID:";
            // 
            // txtclienteID
            // 
            this.txtclienteID.Location = new System.Drawing.Point(98, 412);
            this.txtclienteID.Name = "txtclienteID";
            this.txtclienteID.Size = new System.Drawing.Size(296, 20);
            this.txtclienteID.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Prestador ID:";
            // 
            // txtprestadorID
            // 
            this.txtprestadorID.Location = new System.Drawing.Point(98, 449);
            this.txtprestadorID.Name = "txtprestadorID";
            this.txtprestadorID.Size = new System.Drawing.Size(296, 20);
            this.txtprestadorID.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCliente);
            this.groupBox1.Location = new System.Drawing.Point(438, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 178);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(16, 22);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(240, 150);
            this.dtgCliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPrestador);
            this.groupBox2.Location = new System.Drawing.Point(722, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 178);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestador";
            // 
            // dtgPrestador
            // 
            this.dtgPrestador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestador.Location = new System.Drawing.Point(16, 22);
            this.dtgPrestador.Name = "dtgPrestador";
            this.dtgPrestador.Size = new System.Drawing.Size(240, 150);
            this.dtgPrestador.TabIndex = 0;
            // 
            // FrmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprestadorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtclienteID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAvaliacao);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "FrmAvaliacao";
            this.Text = "Conservadora - Avaliação";
            this.Load += new System.EventHandler(this.FrmAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAvaliacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAvaliacao;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtclienteID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprestadorID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPrestador;
    }
}