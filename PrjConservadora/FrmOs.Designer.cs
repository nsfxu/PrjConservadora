namespace PrjConservadora
{
    partial class FrmOs
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
            this.dtgPrestador = new System.Windows.Forms.DataGridView();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgOs = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgServico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumeroendereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthorascontratadas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprestador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtservico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.dtpabertura = new System.Windows.Forms.DateTimePicker();
            this.dtpservico = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOs)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServico)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPrestador
            // 
            this.dtgPrestador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestador.Location = new System.Drawing.Point(16, 22);
            this.dtgPrestador.Name = "dtgPrestador";
            this.dtgPrestador.Size = new System.Drawing.Size(240, 150);
            this.dtgPrestador.TabIndex = 0;
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(22, 19);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(240, 150);
            this.dtgCliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPrestador);
            this.groupBox2.Location = new System.Drawing.Point(531, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 178);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCliente);
            this.groupBox1.Location = new System.Drawing.Point(828, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 178);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(351, 648);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 43);
            this.btnsair.TabIndex = 14;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(48, 645);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(116, 43);
            this.btninserir.TabIndex = 13;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID:";
            // 
            // dtgOs
            // 
            this.dtgOs.AllowUserToAddRows = false;
            this.dtgOs.AllowUserToDeleteRows = false;
            this.dtgOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOs.Location = new System.Drawing.Point(48, 25);
            this.dtgOs.Name = "dtgOs";
            this.dtgOs.Size = new System.Drawing.Size(1048, 281);
            this.dtgOs.TabIndex = 64;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(122, 339);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(66, 20);
            this.txtid.TabIndex = 0;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(222, 337);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgServico);
            this.groupBox3.Location = new System.Drawing.Point(778, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 178);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço";
            // 
            // dtgServico
            // 
            this.dtgServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServico.Location = new System.Drawing.Point(16, 22);
            this.dtgServico.Name = "dtgServico";
            this.dtgServico.Size = new System.Drawing.Size(240, 150);
            this.dtgServico.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Data Abertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(122, 439);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(187, 20);
            this.txtcep.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Num. Endereço:";
            // 
            // txtnumeroendereco
            // 
            this.txtnumeroendereco.Location = new System.Drawing.Point(122, 471);
            this.txtnumeroendereco.Name = "txtnumeroendereco";
            this.txtnumeroendereco.Size = new System.Drawing.Size(187, 20);
            this.txtnumeroendereco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(122, 505);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(187, 20);
            this.txtcomplemento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "VIP:";
            // 
            // txtvip
            // 
            this.txtvip.Location = new System.Drawing.Point(122, 535);
            this.txtvip.Name = "txtvip";
            this.txtvip.Size = new System.Drawing.Size(77, 20);
            this.txtvip.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Horas Contratadas:";
            // 
            // txthorascontratadas
            // 
            this.txthorascontratadas.Location = new System.Drawing.Point(122, 564);
            this.txthorascontratadas.Name = "txthorascontratadas";
            this.txthorascontratadas.Size = new System.Drawing.Size(77, 20);
            this.txthorascontratadas.TabIndex = 7;
            this.txthorascontratadas.TextChanged += new System.EventHandler(this.txthorascontratadas_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Prestador ID:";
            // 
            // txtprestador
            // 
            this.txtprestador.Location = new System.Drawing.Point(410, 611);
            this.txtprestador.Name = "txtprestador";
            this.txtprestador.Size = new System.Drawing.Size(96, 20);
            this.txtprestador.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Serviços ID:";
            // 
            // txtservico
            // 
            this.txtservico.Location = new System.Drawing.Point(410, 572);
            this.txtservico.Name = "txtservico";
            this.txtservico.Size = new System.Drawing.Size(96, 20);
            this.txtservico.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 535);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Cliente ID:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(410, 535);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(96, 20);
            this.txtcliente.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 92;
            this.label12.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(410, 427);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(338, 46);
            this.txtcomentario.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(410, 331);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(338, 75);
            this.txtdescricao.TabIndex = 8;
            // 
            // dtpabertura
            // 
            this.dtpabertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpabertura.Location = new System.Drawing.Point(122, 374);
            this.dtpabertura.Name = "dtpabertura";
            this.dtpabertura.Size = new System.Drawing.Size(187, 20);
            this.dtpabertura.TabIndex = 1;
            // 
            // dtpservico
            // 
            this.dtpservico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpservico.Location = new System.Drawing.Point(122, 409);
            this.dtpservico.Name = "dtpservico";
            this.dtpservico.Size = new System.Drawing.Size(187, 20);
            this.dtpservico.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Data Serviço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(410, 497);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(96, 20);
            this.txtstatus.TabIndex = 10;
            // 
            // FrmOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 709);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.dtpservico);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpabertura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprestador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtservico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthorascontratadas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumeroendereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgOs);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "FrmOs";
            this.Text = "Conservadora - Os";
            this.Load += new System.EventHandler(this.FrmOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrestador;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgOs;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumeroendereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthorascontratadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprestador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtservico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.DateTimePicker dtpabertura;
        private System.Windows.Forms.DateTimePicker dtpservico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstatus;
    }
}