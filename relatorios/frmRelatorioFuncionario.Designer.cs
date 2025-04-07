namespace sistemaFuturoCraque
{
    partial class frmRelatorioFuncionario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarRelFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarRelFuncionario = new System.Windows.Forms.Button();
            this.btnImprimirRelFuncionario = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(264, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Relatório Funcionário";
            // 
            // btnGerarRelFuncionario
            // 
            this.btnGerarRelFuncionario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGerarRelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelFuncionario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarRelFuncionario.Location = new System.Drawing.Point(713, 54);
            this.btnGerarRelFuncionario.Name = "btnGerarRelFuncionario";
            this.btnGerarRelFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelFuncionario.TabIndex = 13;
            this.btnGerarRelFuncionario.Text = "Gerar";
            this.btnGerarRelFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnSalvarRelFuncionario
            // 
            this.btnSalvarRelFuncionario.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSalvarRelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarRelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelFuncionario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvarRelFuncionario.Location = new System.Drawing.Point(713, 410);
            this.btnSalvarRelFuncionario.Name = "btnSalvarRelFuncionario";
            this.btnSalvarRelFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarRelFuncionario.TabIndex = 14;
            this.btnSalvarRelFuncionario.Text = "Salvar";
            this.btnSalvarRelFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnImprimirRelFuncionario
            // 
            this.btnImprimirRelFuncionario.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirRelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelFuncionario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelFuncionario.Location = new System.Drawing.Point(620, 410);
            this.btnImprimirRelFuncionario.Name = "btnImprimirRelFuncionario";
            this.btnImprimirRelFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelFuncionario.TabIndex = 15;
            this.btnImprimirRelFuncionario.Text = "Imprimir";
            this.btnImprimirRelFuncionario.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaFuturoCraque.relatorios.relFunc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 315);
            this.reportViewer1.TabIndex = 16;
            // 
            // frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnImprimirRelFuncionario);
            this.Controls.Add(this.btnSalvarRelFuncionario);
            this.Controls.Add(this.btnGerarRelFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelatorioFuncionario";
            this.Text = "frmRelatorioFuncionario";
            this.Load += new System.EventHandler(this.frmRelatorioFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarRelFuncionario;
        private System.Windows.Forms.Button btnSalvarRelFuncionario;
        private System.Windows.Forms.Button btnImprimirRelFuncionario;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}