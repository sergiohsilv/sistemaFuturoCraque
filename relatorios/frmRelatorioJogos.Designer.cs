namespace sistemaFuturoCraque
{
    partial class frmRelatorioJogos
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
            System.Windows.Forms.Button btnImprimirJogos;
            this.label1 = new System.Windows.Forms.Label();
            this.panelJogos = new System.Windows.Forms.Panel();
            this.dgvJogos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnImprimirJogos = new System.Windows.Forms.Button();
            this.panelJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimirJogos
            // 
            btnImprimirJogos.BackColor = System.Drawing.Color.DodgerBlue;
            btnImprimirJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnImprimirJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnImprimirJogos.ForeColor = System.Drawing.SystemColors.Window;
            btnImprimirJogos.Location = new System.Drawing.Point(691, 319);
            btnImprimirJogos.Name = "btnImprimirJogos";
            btnImprimirJogos.Size = new System.Drawing.Size(75, 23);
            btnImprimirJogos.TabIndex = 3;
            btnImprimirJogos.Text = "Imprimir";
            btnImprimirJogos.UseVisualStyleBackColor = false;
            btnImprimirJogos.Click += new System.EventHandler(this.btnImprimirJogos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Relatório Jogos";
            // 
            // panelJogos
            // 
            this.panelJogos.Controls.Add(this.btnSair);
            this.panelJogos.Controls.Add(this.dgvJogos);
            this.panelJogos.Controls.Add(btnImprimirJogos);
            this.panelJogos.Location = new System.Drawing.Point(12, 73);
            this.panelJogos.Name = "panelJogos";
            this.panelJogos.Size = new System.Drawing.Size(776, 355);
            this.panelJogos.TabIndex = 14;
            // 
            // dgvJogos
            // 
            this.dgvJogos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogos.Location = new System.Drawing.Point(3, 46);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.Size = new System.Drawing.Size(770, 258);
            this.dgvJogos.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(10, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmRelatorioJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelJogos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelatorioJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioJogos";
            this.Load += new System.EventHandler(this.frmRelatorioJogos_Load);
            this.panelJogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelJogos;
        private System.Windows.Forms.DataGridView dgvJogos;
        private System.Windows.Forms.Button btnSair;
    }
}