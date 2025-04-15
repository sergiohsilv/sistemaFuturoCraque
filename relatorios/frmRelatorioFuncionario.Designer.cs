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
            this.btnImprimirRelFuncionario = new System.Windows.Forms.Button();
            this.panelRelatorioFunc = new System.Windows.Forms.Panel();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRelatorioFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
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
            // btnImprimirRelFuncionario
            // 
            this.btnImprimirRelFuncionario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirRelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelFuncionario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelFuncionario.Location = new System.Drawing.Point(691, 319);
            this.btnImprimirRelFuncionario.Name = "btnImprimirRelFuncionario";
            this.btnImprimirRelFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelFuncionario.TabIndex = 15;
            this.btnImprimirRelFuncionario.Text = "Imprimir";
            this.btnImprimirRelFuncionario.UseVisualStyleBackColor = false;
            this.btnImprimirRelFuncionario.Click += new System.EventHandler(this.btnImprimirRelFuncionario_Click);
            // 
            // panelRelatorioFunc
            // 
            this.panelRelatorioFunc.Controls.Add(this.button1);
            this.panelRelatorioFunc.Controls.Add(this.dgvFuncionario);
            this.panelRelatorioFunc.Controls.Add(this.btnImprimirRelFuncionario);
            this.panelRelatorioFunc.Location = new System.Drawing.Point(12, 73);
            this.panelRelatorioFunc.Name = "panelRelatorioFunc";
            this.panelRelatorioFunc.Size = new System.Drawing.Size(776, 355);
            this.panelRelatorioFunc.TabIndex = 16;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(3, 46);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(770, 258);
            this.dgvFuncionario.TabIndex = 16;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(10, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRelatorioFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelatorioFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioFuncionario";
            this.Load += new System.EventHandler(this.frmRelatorioFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRelatorioFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirRelFuncionario;
        private System.Windows.Forms.Panel panelRelatorioFunc;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button button1;
    }
}