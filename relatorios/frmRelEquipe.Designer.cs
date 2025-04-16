namespace sistemaFuturoCraque
{
    partial class frmRelEquipe
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
            this.panelEquipe = new System.Windows.Forms.Panel();
            this.dgvEquipe = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimirEquipe = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelEquipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Relatorio Equipe";
            // 
            // panelEquipe
            // 
            this.panelEquipe.Controls.Add(this.btnSair);
            this.panelEquipe.Controls.Add(this.btnImprimirEquipe);
            this.panelEquipe.Controls.Add(this.dgvEquipe);
            this.panelEquipe.Location = new System.Drawing.Point(12, 73);
            this.panelEquipe.Name = "panelEquipe";
            this.panelEquipe.Size = new System.Drawing.Size(776, 355);
            this.panelEquipe.TabIndex = 15;
            // 
            // dgvEquipe
            // 
            this.dgvEquipe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipe.Location = new System.Drawing.Point(3, 46);
            this.dgvEquipe.Name = "dgvEquipe";
            this.dgvEquipe.Size = new System.Drawing.Size(770, 258);
            this.dgvEquipe.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimirEquipe
            // 
            this.btnImprimirEquipe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimirEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirEquipe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirEquipe.Location = new System.Drawing.Point(691, 319);
            this.btnImprimirEquipe.Name = "btnImprimirEquipe";
            this.btnImprimirEquipe.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirEquipe.TabIndex = 1;
            this.btnImprimirEquipe.Text = "Imprimir";
            this.btnImprimirEquipe.UseVisualStyleBackColor = false;
            this.btnImprimirEquipe.Click += new System.EventHandler(this.btnImprimirEquipe_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(10, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRelEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEquipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelEquipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelEquipe";
            this.panelEquipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEquipe;
        private System.Windows.Forms.DataGridView dgvEquipe;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimirEquipe;
    }
}