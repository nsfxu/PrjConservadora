namespace PrjConservadora
{
    partial class FrmPrest
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txthorascontratadas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumeroendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpservico = new System.Windows.Forms.DateTimePicker();
            this.dtpabertura = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(75, 358);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(104, 39);
            this.btnfechar.TabIndex = 1;
            this.btnfechar.Text = "Fechar Chamado";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(895, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chamados";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(79, 332);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(38, 332);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 135;
            this.label8.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Location = new System.Drawing.Point(411, 180);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(96, 20);
            this.txtstatus.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 134;
            this.label15.Text = "Data Serviço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "Prestador ID:";
            // 
            // txtprestador
            // 
            this.txtprestador.Enabled = false;
            this.txtprestador.Location = new System.Drawing.Point(411, 294);
            this.txtprestador.Name = "txtprestador";
            this.txtprestador.Size = new System.Drawing.Size(96, 20);
            this.txtprestador.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 132;
            this.label10.Text = "Serviços ID:";
            // 
            // txtservico
            // 
            this.txtservico.Enabled = false;
            this.txtservico.Location = new System.Drawing.Point(411, 255);
            this.txtservico.Name = "txtservico";
            this.txtservico.Size = new System.Drawing.Size(96, 20);
            this.txtservico.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 131;
            this.label11.Text = "Cliente ID:";
            // 
            // txtcliente
            // 
            this.txtcliente.Enabled = false;
            this.txtcliente.Location = new System.Drawing.Point(411, 218);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(96, 20);
            this.txtcliente.TabIndex = 118;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 130;
            this.label12.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Enabled = false;
            this.txtcomentario.Location = new System.Drawing.Point(411, 110);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(338, 46);
            this.txtcomentario.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 129;
            this.label13.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(411, 24);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(338, 75);
            this.txtdescricao.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 128;
            this.label7.Text = "Horas Contratadas:";
            // 
            // txthorascontratadas
            // 
            this.txthorascontratadas.Enabled = false;
            this.txthorascontratadas.Location = new System.Drawing.Point(119, 218);
            this.txthorascontratadas.Name = "txthorascontratadas";
            this.txthorascontratadas.Size = new System.Drawing.Size(77, 20);
            this.txthorascontratadas.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "VIP:";
            // 
            // txtvip
            // 
            this.txtvip.Enabled = false;
            this.txtvip.Location = new System.Drawing.Point(119, 189);
            this.txtvip.Name = "txtvip";
            this.txtvip.Size = new System.Drawing.Size(77, 20);
            this.txtvip.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 126;
            this.label5.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Enabled = false;
            this.txtcomplemento.Location = new System.Drawing.Point(119, 159);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(187, 20);
            this.txtcomplemento.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 125;
            this.label4.Text = "Num. Endereço:";
            // 
            // txtnumeroendereco
            // 
            this.txtnumeroendereco.Enabled = false;
            this.txtnumeroendereco.Location = new System.Drawing.Point(119, 125);
            this.txtnumeroendereco.Name = "txtnumeroendereco";
            this.txtnumeroendereco.Size = new System.Drawing.Size(187, 20);
            this.txtnumeroendereco.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.Enabled = false;
            this.txtcep.Location = new System.Drawing.Point(119, 93);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(187, 20);
            this.txtcep.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 123;
            this.label14.Text = "Data Abertura:";
            // 
            // dtpservico
            // 
            this.dtpservico.Enabled = false;
            this.dtpservico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpservico.Location = new System.Drawing.Point(119, 61);
            this.dtpservico.Name = "dtpservico";
            this.dtpservico.Size = new System.Drawing.Size(187, 20);
            this.dtpservico.TabIndex = 137;
            // 
            // dtpabertura
            // 
            this.dtpabertura.Enabled = false;
            this.dtpabertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpabertura.Location = new System.Drawing.Point(119, 26);
            this.dtpabertura.Name = "dtpabertura";
            this.dtpabertura.Size = new System.Drawing.Size(187, 20);
            this.dtpabertura.TabIndex = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpservico);
            this.groupBox1.Controls.Add(this.txtcep);
            this.groupBox1.Controls.Add(this.dtpabertura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnumeroendereco);
            this.groupBox1.Controls.Add(this.txtstatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtcomplemento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtprestador);
            this.groupBox1.Controls.Add(this.txtvip);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtservico);
            this.groupBox1.Controls.Add(this.txthorascontratadas);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.txtdescricao);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtcomentario);
            this.groupBox1.Location = new System.Drawing.Point(201, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 342);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // FrmPrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrest";
            this.Text = "Conservadora - Prestador";
            this.Load += new System.EventHandler(this.FrmPrest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label15;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthorascontratadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumeroendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpservico;
        private System.Windows.Forms.DateTimePicker dtpabertura;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}