namespace sistemaFuturoCraque
{
    partial class frmRelatorioEquipamento
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
            this.btnImprimirRelEquipamento = new System.Windows.Forms.Button();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEquipamento = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Relatório de Equipamento";
            // 
            // btnImprimirRelEquipamento
            // 
            this.btnImprimirRelEquipamento.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimirRelEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelEquipamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelEquipamento.Location = new System.Drawing.Point(691, 319);
            this.btnImprimirRelEquipamento.Name = "btnImprimirRelEquipamento";
            this.btnImprimirRelEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelEquipamento.TabIndex = 17;
            this.btnImprimirRelEquipamento.Text = "Imprimir";
            this.btnImprimirRelEquipamento.UseVisualStyleBackColor = false;
            this.btnImprimirRelEquipamento.Click += new System.EventHandler(this.btnImprimirRelEquipamento_Click);
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.btnSair);
            this.panelRelatorio.Controls.Add(this.label2);
            this.panelRelatorio.Controls.Add(this.dgvEquipamento);
            this.panelRelatorio.Controls.Add(this.btnImprimirRelEquipamento);
            this.panelRelatorio.Location = new System.Drawing.Point(12, 73);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(776, 355);
            this.panelRelatorio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Relatorio Equipamento";
            // 
            // dgvEquipamento
            // 
            this.dgvEquipamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamento.Location = new System.Drawing.Point(3, 46);
            this.dgvEquipamento.Name = "dgvEquipamento";
            this.dgvEquipamento.Size = new System.Drawing.Size(770, 258);
            this.dgvEquipamento.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(10, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmRelatorioEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelatorioEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioEquipamento";
            this.Load += new System.EventHandler(this.frmRelatorioEquipamento_Load);
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirRelEquipamento;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.DataGridView dgvEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
    }
}