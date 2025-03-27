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
            System.Windows.Forms.Button btnSalvarRelJogos;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGerarRelJogos = new System.Windows.Forms.Button();
            this.btnImprimirRelJogos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            btnSalvarRelJogos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGerarRelJogos
            // 
            this.btnGerarRelJogos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGerarRelJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelJogos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarRelJogos.Location = new System.Drawing.Point(713, 85);
            this.btnGerarRelJogos.Name = "btnGerarRelJogos";
            this.btnGerarRelJogos.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelJogos.TabIndex = 1;
            this.btnGerarRelJogos.Text = "Gerar";
            this.btnGerarRelJogos.UseVisualStyleBackColor = false;
            // 
            // btnImprimirRelJogos
            // 
            this.btnImprimirRelJogos.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirRelJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelJogos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelJogos.Location = new System.Drawing.Point(620, 410);
            this.btnImprimirRelJogos.Name = "btnImprimirRelJogos";
            this.btnImprimirRelJogos.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelJogos.TabIndex = 2;
            this.btnImprimirRelJogos.Text = "Imprimir";
            this.btnImprimirRelJogos.UseVisualStyleBackColor = false;
            // 
            // btnSalvarRelJogos
            // 
            btnSalvarRelJogos.BackColor = System.Drawing.Color.MediumBlue;
            btnSalvarRelJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSalvarRelJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSalvarRelJogos.ForeColor = System.Drawing.SystemColors.Window;
            btnSalvarRelJogos.Location = new System.Drawing.Point(713, 410);
            btnSalvarRelJogos.Name = "btnSalvarRelJogos";
            btnSalvarRelJogos.Size = new System.Drawing.Size(75, 23);
            btnSalvarRelJogos.TabIndex = 3;
            btnSalvarRelJogos.Text = "Salvar";
            btnSalvarRelJogos.UseVisualStyleBackColor = false;
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
            // frmRelatorioJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(btnSalvarRelJogos);
            this.Controls.Add(this.btnImprimirRelJogos);
            this.Controls.Add(this.btnGerarRelJogos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRelatorioJogos";
            this.Text = "frmRelatorioJogos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGerarRelJogos;
        private System.Windows.Forms.Button btnImprimirRelJogos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}