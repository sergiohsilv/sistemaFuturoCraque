﻿namespace sistemaFuturoCraque
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimirRelReserva = new System.Windows.Forms.Button();
            this.panelReserva = new System.Windows.Forms.Panel();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // btnImprimirRelReserva
            // 
            this.btnImprimirRelReserva.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirRelReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimirRelReserva.Location = new System.Drawing.Point(691, 319);
            this.btnImprimirRelReserva.Name = "btnImprimirRelReserva";
            this.btnImprimirRelReserva.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRelReserva.TabIndex = 16;
            this.btnImprimirRelReserva.Text = "Imprimir";
            this.btnImprimirRelReserva.UseVisualStyleBackColor = false;
            this.btnImprimirRelReserva.Click += new System.EventHandler(this.btnImprimirRelReserva_Click);
            // 
            // panelReserva
            // 
            this.panelReserva.Controls.Add(this.btnSair);
            this.panelReserva.Controls.Add(this.dgvReserva);
            this.panelReserva.Controls.Add(this.btnImprimirRelReserva);
            this.panelReserva.Location = new System.Drawing.Point(12, 73);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Size = new System.Drawing.Size(776, 355);
            this.panelReserva.TabIndex = 17;
            // 
            // dgvReserva
            // 
            this.dgvReserva.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(3, 46);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(770, 258);
            this.dgvReserva.TabIndex = 17;
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
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(10, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRelatorioReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRelatorioReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioReserva";
            this.Load += new System.EventHandler(this.frmRelatorioReserva_Load);
            this.panelReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirRelReserva;
        private System.Windows.Forms.Panel panelReserva;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnSair;
    }
}