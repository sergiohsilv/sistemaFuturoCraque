namespace sistemaFuturoCraque.relatorios
{
    partial class frmRelAluno
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGerarRel = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaFuturoCraque.relatorios.relAluno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 315);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGerarRel
            // 
            this.btnGerarRel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGerarRel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarRel.Location = new System.Drawing.Point(713, 54);
            this.btnGerarRel.Name = "btnGerarRel";
            this.btnGerarRel.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRel.TabIndex = 1;
            this.btnGerarRel.Text = "Gerar";
            this.btnGerarRel.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(713, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Location = new System.Drawing.Point(632, 415);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(302, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Relatório Aluno";
            // 
            // frmRelAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnGerarRel);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelAluno";
            this.Text = "frmRelAluno";
            this.Load += new System.EventHandler(this.frmRelAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGerarRel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}