namespace sistemaFuturoCraque
{
    partial class frmRelatorioAlunos
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
            this.dgvRelAlunos = new System.Windows.Forms.DataGridView();
            this.btnSalvarRelAlunos = new System.Windows.Forms.Button();
            this.btnImprimirRelAlunos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelAlunos
            // 
            this.dgvRelAlunos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRelAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelAlunos.Location = new System.Drawing.Point(0, 118);
            this.dgvRelAlunos.Name = "dgvRelAlunos";
            this.dgvRelAlunos.Size = new System.Drawing.Size(802, 281);
            this.dgvRelAlunos.TabIndex = 0;
            // 
            // btnSalvarRelAlunos
            // 
            this.btnSalvarRelAlunos.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSalvarRelAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarRelAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelAlunos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvarRelAlunos.Location = new System.Drawing.Point(713, 410);
            this.btnSalvarRelAlunos.Name = "btnSalvarRelAlunos";
            this.btnSalvarRelAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarRelAlunos.TabIndex = 1;
            this.btnSalvarRelAlunos.Text = "Salvar";
            this.btnSalvarRelAlunos.UseVisualStyleBackColor = false;
            // 
            // btnImprimirRelAlunos
            // 
            this.btnImprimirRelAlunos.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirRelAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelAlunos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelAlunos.Location = new System.Drawing.Point(620, 410);
            this.btnImprimirRelAlunos.Name = "btnImprimirRelAlunos";
            this.btnImprimirRelAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelAlunos.TabIndex = 2;
            this.btnImprimirRelAlunos.Text = "Imprimir";
            this.btnImprimirRelAlunos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Relatório Alunos";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(713, 85);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelatorio.TabIndex = 12;
            this.btnGerarRelatorio.Text = "Gerar";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmRelatorioAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImprimirRelAlunos);
            this.Controls.Add(this.btnSalvarRelAlunos);
            this.Controls.Add(this.dgvRelAlunos);
            this.Name = "frmRelatorioAlunos";
            this.Text = "frmRelatorioAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelAlunos;
        private System.Windows.Forms.Button btnSalvarRelAlunos;
        private System.Windows.Forms.Button btnImprimirRelAlunos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}