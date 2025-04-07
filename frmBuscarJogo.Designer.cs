namespace sistemaFuturoCraque
{
    partial class frmBuscarJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarJogo));
            this.dgvBuscarJogo = new System.Windows.Forms.DataGridView();
            this.txtBuscarJogo = new System.Windows.Forms.TextBox();
            this.btnBuscarJogo = new System.Windows.Forms.Button();
            this.btnEditarJogo = new System.Windows.Forms.Button();
            this.btnExcluirJogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarJogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarJogo
            // 
            this.dgvBuscarJogo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBuscarJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarJogo.Location = new System.Drawing.Point(99, 150);
            this.dgvBuscarJogo.Name = "dgvBuscarJogo";
            this.dgvBuscarJogo.Size = new System.Drawing.Size(590, 220);
            this.dgvBuscarJogo.TabIndex = 0;
            // 
            // txtBuscarJogo
            // 
            this.txtBuscarJogo.Location = new System.Drawing.Point(212, 111);
            this.txtBuscarJogo.Name = "txtBuscarJogo";
            this.txtBuscarJogo.Size = new System.Drawing.Size(378, 20);
            this.txtBuscarJogo.TabIndex = 1;
            // 
            // btnBuscarJogo
            // 
            this.btnBuscarJogo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarJogo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarJogo.Location = new System.Drawing.Point(614, 111);
            this.btnBuscarJogo.Name = "btnBuscarJogo";
            this.btnBuscarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarJogo.TabIndex = 3;
            this.btnBuscarJogo.Text = "Buscar";
            this.btnBuscarJogo.UseVisualStyleBackColor = false;
            this.btnBuscarJogo.Click += new System.EventHandler(this.btnBuscarJogo_Click);
            // 
            // btnEditarJogo
            // 
            this.btnEditarJogo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarJogo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarJogo.Location = new System.Drawing.Point(533, 376);
            this.btnEditarJogo.Name = "btnEditarJogo";
            this.btnEditarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarJogo.TabIndex = 4;
            this.btnEditarJogo.Text = "Editar";
            this.btnEditarJogo.UseVisualStyleBackColor = false;
            // 
            // btnExcluirJogo
            // 
            this.btnExcluirJogo.BackColor = System.Drawing.Color.Red;
            this.btnExcluirJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirJogo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluirJogo.Location = new System.Drawing.Point(614, 376);
            this.btnExcluirJogo.Name = "btnExcluirJogo";
            this.btnExcluirJogo.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirJogo.TabIndex = 5;
            this.btnExcluirJogo.Text = "Excluir";
            this.btnExcluirJogo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(320, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Jogo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarJogo
            // 
            this.btnCadastrarJogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarJogo.BackgroundImage")));
            this.btnCadastrarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarJogo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarJogo.Location = new System.Drawing.Point(99, 109);
            this.btnCadastrarJogo.Name = "btnCadastrarJogo";
            this.btnCadastrarJogo.Size = new System.Drawing.Size(104, 25);
            this.btnCadastrarJogo.TabIndex = 2;
            this.btnCadastrarJogo.Text = "+ Cadastrar";
            this.btnCadastrarJogo.UseVisualStyleBackColor = true;
            this.btnCadastrarJogo.Click += new System.EventHandler(this.btnCadastrarJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(12, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistemaFuturoCraque.Properties.Resources.Futuro_Craque_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(215, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmBuscarJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExcluirJogo);
            this.Controls.Add(this.btnEditarJogo);
            this.Controls.Add(this.btnBuscarJogo);
            this.Controls.Add(this.btnCadastrarJogo);
            this.Controls.Add(this.txtBuscarJogo);
            this.Controls.Add(this.dgvBuscarJogo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmBuscarJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarJogo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarJogo;
        private System.Windows.Forms.TextBox txtBuscarJogo;
        private System.Windows.Forms.Button btnCadastrarJogo;
        private System.Windows.Forms.Button btnBuscarJogo;
        private System.Windows.Forms.Button btnEditarJogo;
        private System.Windows.Forms.Button btnExcluirJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}