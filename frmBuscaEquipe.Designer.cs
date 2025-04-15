namespace sistemaFuturoCraque
{
    partial class frmBuscaEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaEquipe));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarEquipe = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarEquipe = new System.Windows.Forms.Button();
            this.btnBuscarEquipe = new System.Windows.Forms.Button();
            this.btnExcluirEquipe = new System.Windows.Forms.Button();
            this.btnEditarEquipe = new System.Windows.Forms.Button();
            this.txtBuscarEquipe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Busca Equipe";
            // 
            // dgvBuscarEquipe
            // 
            this.dgvBuscarEquipe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBuscarEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarEquipe.Location = new System.Drawing.Point(99, 150);
            this.dgvBuscarEquipe.Name = "dgvBuscarEquipe";
            this.dgvBuscarEquipe.Size = new System.Drawing.Size(590, 220);
            this.dgvBuscarEquipe.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFuturoCraque.Properties.Resources.Captura_de_tela_2025_03_13_083650;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarEquipe
            // 
            this.btnCadastrarEquipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEquipe.BackgroundImage")));
            this.btnCadastrarEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEquipe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarEquipe.Location = new System.Drawing.Point(99, 109);
            this.btnCadastrarEquipe.Name = "btnCadastrarEquipe";
            this.btnCadastrarEquipe.Size = new System.Drawing.Size(104, 25);
            this.btnCadastrarEquipe.TabIndex = 17;
            this.btnCadastrarEquipe.Text = "+ Cadastrar";
            this.btnCadastrarEquipe.UseVisualStyleBackColor = true;
            this.btnCadastrarEquipe.Click += new System.EventHandler(this.btnCadastrarEquipe_Click);
            // 
            // btnBuscarEquipe
            // 
            this.btnBuscarEquipe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEquipe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarEquipe.Location = new System.Drawing.Point(614, 111);
            this.btnBuscarEquipe.Name = "btnBuscarEquipe";
            this.btnBuscarEquipe.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEquipe.TabIndex = 18;
            this.btnBuscarEquipe.Text = "Buscar";
            this.btnBuscarEquipe.UseVisualStyleBackColor = false;
            this.btnBuscarEquipe.Click += new System.EventHandler(this.btnBuscarEquipe_Click);
            // 
            // btnExcluirEquipe
            // 
            this.btnExcluirEquipe.BackColor = System.Drawing.Color.Red;
            this.btnExcluirEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEquipe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluirEquipe.Location = new System.Drawing.Point(614, 376);
            this.btnExcluirEquipe.Name = "btnExcluirEquipe";
            this.btnExcluirEquipe.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEquipe.TabIndex = 19;
            this.btnExcluirEquipe.Text = "Excluir";
            this.btnExcluirEquipe.UseVisualStyleBackColor = false;
            this.btnExcluirEquipe.Click += new System.EventHandler(this.btnExcluirEquipe_Click);
            // 
            // btnEditarEquipe
            // 
            this.btnEditarEquipe.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditarEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEquipe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarEquipe.Location = new System.Drawing.Point(533, 376);
            this.btnEditarEquipe.Name = "btnEditarEquipe";
            this.btnEditarEquipe.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEquipe.TabIndex = 20;
            this.btnEditarEquipe.Text = "Editar";
            this.btnEditarEquipe.UseVisualStyleBackColor = false;
            this.btnEditarEquipe.Click += new System.EventHandler(this.btnEditarEquipe_Click);
            // 
            // txtBuscarEquipe
            // 
            this.txtBuscarEquipe.Location = new System.Drawing.Point(212, 111);
            this.txtBuscarEquipe.Name = "txtBuscarEquipe";
            this.txtBuscarEquipe.Size = new System.Drawing.Size(378, 20);
            this.txtBuscarEquipe.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistemaFuturoCraque.Properties.Resources.Futuro_Craque_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(215, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // frmBuscaEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarEquipe);
            this.Controls.Add(this.btnEditarEquipe);
            this.Controls.Add(this.btnExcluirEquipe);
            this.Controls.Add(this.btnBuscarEquipe);
            this.Controls.Add(this.btnCadastrarEquipe);
            this.Controls.Add(this.dgvBuscarEquipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmBuscaEquipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarEquipe;
        private System.Windows.Forms.Button btnCadastrarEquipe;
        private System.Windows.Forms.Button btnBuscarEquipe;
        private System.Windows.Forms.Button btnExcluirEquipe;
        private System.Windows.Forms.Button btnEditarEquipe;
        private System.Windows.Forms.TextBox txtBuscarEquipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}