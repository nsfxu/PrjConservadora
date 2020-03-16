namespace PrjConservadora
{
    partial class FrmRelatorio
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
            this.dtgresumitivo = new System.Windows.Forms.DataGridView();
            this.dtgservicos = new System.Windows.Forms.DataGridView();
            this.dtgclientes = new System.Windows.Forms.DataGridView();
            this.dtgprestadores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgresumitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgservicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprestadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgresumitivo
            // 
            this.dtgresumitivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgresumitivo.Location = new System.Drawing.Point(71, 167);
            this.dtgresumitivo.Name = "dtgresumitivo";
            this.dtgresumitivo.Size = new System.Drawing.Size(252, 173);
            this.dtgresumitivo.TabIndex = 0;
            // 
            // dtgservicos
            // 
            this.dtgservicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgservicos.Location = new System.Drawing.Point(432, 167);
            this.dtgservicos.Name = "dtgservicos";
            this.dtgservicos.Size = new System.Drawing.Size(252, 173);
            this.dtgservicos.TabIndex = 1;
            // 
            // dtgclientes
            // 
            this.dtgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgclientes.Location = new System.Drawing.Point(71, 398);
            this.dtgclientes.Name = "dtgclientes";
            this.dtgclientes.Size = new System.Drawing.Size(252, 173);
            this.dtgclientes.TabIndex = 2;
            // 
            // dtgprestadores
            // 
            this.dtgprestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgprestadores.Location = new System.Drawing.Point(432, 398);
            this.dtgprestadores.Name = "dtgprestadores";
            this.dtgprestadores.Size = new System.Drawing.Size(252, 173);
            this.dtgprestadores.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resumitivo do mês";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serviços mais pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clientes mais bem avaliados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prestadores mais bem avaliados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Relatório";
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgprestadores);
            this.Controls.Add(this.dtgclientes);
            this.Controls.Add(this.dtgservicos);
            this.Controls.Add(this.dtgresumitivo);
            this.Name = "FrmRelatorio";
            this.Text = "Conservadora - Relatório";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgresumitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgservicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprestadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgresumitivo;
        private System.Windows.Forms.DataGridView dtgservicos;
        private System.Windows.Forms.DataGridView dtgclientes;
        private System.Windows.Forms.DataGridView dtgprestadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}