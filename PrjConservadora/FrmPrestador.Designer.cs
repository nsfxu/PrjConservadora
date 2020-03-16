namespace PrjConservadora
{
    partial class FrmPrestador
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
            this.dtgPrestador = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvip = new System.Windows.Forms.TextBox();
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcategoriaID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(491, 493);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 43);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(135, 493);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(116, 43);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(102, 454);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(221, 20);
            this.txtcpf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(410, 413);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(221, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(102, 410);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 20);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Sobrenome:";
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(410, 368);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(221, 20);
            this.txtsobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(102, 368);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(221, 20);
            this.txtnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID:";
            // 
            // dtgPrestador
            // 
            this.dtgPrestador.AllowUserToAddRows = false;
            this.dtgPrestador.AllowUserToDeleteRows = false;
            this.dtgPrestador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestador.Location = new System.Drawing.Point(38, 12);
            this.dtgPrestador.Name = "dtgPrestador";
            this.dtgPrestador.Size = new System.Drawing.Size(886, 281);
            this.dtgPrestador.TabIndex = 40;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 328);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(66, 20);
            this.txtid.TabIndex = 0;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(189, 328);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "VIP:";
            // 
            // txtvip
            // 
            this.txtvip.Location = new System.Drawing.Point(410, 328);
            this.txtvip.Name = "txtvip";
            this.txtvip.Size = new System.Drawing.Size(66, 20);
            this.txtvip.TabIndex = 7;
            // 
            // dtgCategoria
            // 
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Location = new System.Drawing.Point(22, 30);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.Size = new System.Drawing.Size(240, 150);
            this.dtgCategoria.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCategoria);
            this.groupBox1.Location = new System.Drawing.Point(651, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 213);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Categoria ID:";
            // 
            // txtcategoriaID
            // 
            this.txtcategoriaID.Location = new System.Drawing.Point(410, 454);
            this.txtcategoriaID.Name = "txtcategoriaID";
            this.txtcategoriaID.Size = new System.Drawing.Size(66, 20);
            this.txtcategoriaID.TabIndex = 6;
            // 
            // FrmPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 553);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcategoriaID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvip);
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
            this.Controls.Add(this.dtgPrestador);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "FrmPrestador";
            this.Text = "Conservadora - Prestador";
            this.Load += new System.EventHandler(this.FrmPrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dtgPrestador;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvip;
        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcategoriaID;
    }
}