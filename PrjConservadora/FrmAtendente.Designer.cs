namespace PrjConservadora
{
    partial class FrmAtendente
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxescolha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecione uma opção para começar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(213, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Começar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxescolha
            // 
            this.cbxescolha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxescolha.FormattingEnabled = true;
            this.cbxescolha.Items.AddRange(new object[] {
            "Cliente",
            "Os"});
            this.cbxescolha.Location = new System.Drawing.Point(288, 200);
            this.cbxescolha.Name = "cbxescolha";
            this.cbxescolha.Size = new System.Drawing.Size(196, 21);
            this.cbxescolha.Sorted = true;
            this.cbxescolha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conservadora Virtual";
            // 
            // FrmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxescolha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAtendente";
            this.Text = "Conservadora - Atendente";
            this.Load += new System.EventHandler(this.FrmAtendente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxescolha;
        private System.Windows.Forms.Label label3;
    }
}