namespace sistemaFuturoCraque
{
    partial class frmRelatorioReserva
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarRelReserva = new System.Windows.Forms.Button();
            this.btnSalvarRelReserva = new System.Windows.Forms.Button();
            this.btnImprimirRelReserva = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Relatório de Reserva";
            // 
            // btnGerarRelReserva
            // 
            this.btnGerarRelReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGerarRelReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarRelReserva.Location = new System.Drawing.Point(713, 85);
            this.btnGerarRelReserva.Name = "btnGerarRelReserva";
            this.btnGerarRelReserva.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelReserva.TabIndex = 14;
            this.btnGerarRelReserva.Text = "Gerar";
            this.btnGerarRelReserva.UseVisualStyleBackColor = false;
            // 
            // btnSalvarRelReserva
            // 
            this.btnSalvarRelReserva.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSalvarRelReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarRelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvarRelReserva.Location = new System.Drawing.Point(713, 410);
            this.btnSalvarRelReserva.Name = "btnSalvarRelReserva";
            this.btnSalvarRelReserva.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarRelReserva.TabIndex = 15;
            this.btnSalvarRelReserva.Text = "Salvar";
            this.btnSalvarRelReserva.UseVisualStyleBackColor = false;
            // 
            // btnImprimirRelReserva
            // 
            this.btnImprimirRelReserva.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirRelReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelReserva.Location = new System.Drawing.Point(620, 410);
            this.btnImprimirRelReserva.Name = "btnImprimirRelReserva";
            this.btnImprimirRelReserva.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelReserva.TabIndex = 16;
            this.btnImprimirRelReserva.Text = "Imprimir";
            this.btnImprimirRelReserva.UseVisualStyleBackColor = false;
            // 
            // frmRelatorioReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimirRelReserva);
            this.Controls.Add(this.btnSalvarRelReserva);
            this.Controls.Add(this.btnGerarRelReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRelatorioReserva";
            this.Text = "frmRelatorioReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarRelReserva;
        private System.Windows.Forms.Button btnSalvarRelReserva;
        private System.Windows.Forms.Button btnImprimirRelReserva;
    }
}