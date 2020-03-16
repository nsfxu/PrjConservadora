namespace PrjConservadora
{
    partial class FrmServicos
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
            this.txtcategoriaID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalorvip = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtminimohora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgServico = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcategoriaID
            // 
            this.txtcategoriaID.Location = new System.Drawing.Point(396, 458);
            this.txtcategoriaID.Name = "txtcategoriaID";
            this.txtcategoriaID.Size = new System.Drawing.Size(66, 20);
            this.txtcategoriaID.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCategoria);
            this.groupBox1.Location = new System.Drawing.Point(637, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 213);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // dtgCategoria
            // 
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Location = new System.Drawing.Point(22, 30);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.Size = new System.Drawing.Size(240, 150);
            this.dtgCategoria.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Categoria ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Valor Hora VIP:";
            // 
            // txtvalorvip
            // 
            this.txtvalorvip.Location = new System.Drawing.Point(396, 377);
            this.txtvalorvip.Name = "txtvalorvip";
            this.txtvalorvip.Size = new System.Drawing.Size(210, 20);
            this.txtvalorvip.TabIndex = 3;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(450, 493);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 43);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(74, 493);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(116, 43);
            this.btninserir.TabIndex = 6;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Minimo Hora:";
            // 
            // txtminimohora
            // 
            this.txtminimohora.Location = new System.Drawing.Point(396, 421);
            this.txtminimohora.Name = "txtminimohora";
            this.txtminimohora.Size = new System.Drawing.Size(210, 20);
            this.txtminimohora.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Valor Hora:";
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Location = new System.Drawing.Point(396, 331);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(210, 20);
            this.txtvalorhora.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(74, 368);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(221, 94);
            this.txtdescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID:";
            // 
            // dtgServico
            // 
            this.dtgServico.AllowUserToAddRows = false;
            this.dtgServico.AllowUserToDeleteRows = false;
            this.dtgServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServico.Location = new System.Drawing.Point(33, 23);
            this.dtgServico.Name = "dtgServico";
            this.dtgServico.Size = new System.Drawing.Size(886, 281);
            this.dtgServico.TabIndex = 64;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(74, 328);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(66, 20);
            this.txtid.TabIndex = 0;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(161, 328);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 561);
            this.Controls.Add(this.txtcategoriaID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvalorvip);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtminimohora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgServico);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "FrmServicos";
            this.Text = "Conservadora - Serviços";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcategoriaID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalorvip;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtminimohora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgServico;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
    }
}