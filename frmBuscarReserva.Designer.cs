namespace sistemaFuturoCraque
{
    partial class frmBuscarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarReserva));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscaReserva = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarReserva = new System.Windows.Forms.TextBox();
            this.btnCadastrarReserva = new System.Windows.Forms.Button();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnExcluirReserva = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(298, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar Reserva";
            // 
            // dgvBuscaReserva
            // 
            this.dgvBuscaReserva.AllowUserToOrderColumns = true;
            this.dgvBuscaReserva.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBuscaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaReserva.Location = new System.Drawing.Point(99, 150);
            this.dgvBuscaReserva.Name = "dgvBuscaReserva";
            this.dgvBuscaReserva.Size = new System.Drawing.Size(590, 220);
            this.dgvBuscaReserva.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarReserva
            // 
            this.txtBuscarReserva.Location = new System.Drawing.Point(212, 111);
            this.txtBuscarReserva.Name = "txtBuscarReserva";
            this.txtBuscarReserva.Size = new System.Drawing.Size(378, 20);
            this.txtBuscarReserva.TabIndex = 12;
            // 
            // btnCadastrarReserva
            // 
            this.btnCadastrarReserva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarReserva.BackgroundImage")));
            this.btnCadastrarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarReserva.Location = new System.Drawing.Point(99, 109);
            this.btnCadastrarReserva.Name = "btnCadastrarReserva";
            this.btnCadastrarReserva.Size = new System.Drawing.Size(104, 25);
            this.btnCadastrarReserva.TabIndex = 13;
            this.btnCadastrarReserva.Text = "+ Cadastrar";
            this.btnCadastrarReserva.UseVisualStyleBackColor = true;
            this.btnCadastrarReserva.Click += new System.EventHandler(this.btnCadastrarReserva_Click);
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarReserva.Location = new System.Drawing.Point(614, 111);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarReserva.TabIndex = 14;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = false;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarReserva.Location = new System.Drawing.Point(533, 376);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnEditarReserva.TabIndex = 15;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.UseVisualStyleBackColor = false;
            // 
            // btnExcluirReserva
            // 
            this.btnExcluirReserva.BackColor = System.Drawing.Color.Red;
            this.btnExcluirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluirReserva.Location = new System.Drawing.Point(614, 376);
            this.btnExcluirReserva.Name = "btnExcluirReserva";
            this.btnExcluirReserva.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirReserva.TabIndex = 16;
            this.btnExcluirReserva.Text = "Excluir";
            this.btnExcluirReserva.UseVisualStyleBackColor = false;
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
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.btnCadastrarReserva);
            this.Controls.Add(this.txtBuscarReserva);
            this.Controls.Add(this.dgvBuscaReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscaReserva;
        private System.Windows.Forms.TextBox txtBuscarReserva;
        private System.Windows.Forms.Button btnCadastrarReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnExcluirReserva;
        private System.Windows.Forms.Button btnSair;
    }
}