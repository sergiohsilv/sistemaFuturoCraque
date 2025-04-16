using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sistemaFuturoCraque
{
    public partial class frmRelatorioReserva : Form
    {
        private PrintDocument documento = new PrintDocument();
        public frmRelatorioReserva()
        {
            InitializeComponent();
            documento.PrintPage += Documento_PrintPage;
        }

        public void CarregarDados(DataTable dados)
        {
            dgvReserva.DataSource = dados;
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fonteTitulo = new Font("Arial", 18, FontStyle.Bold);
            Font fonteCabecalho = new Font("Arial", 12, FontStyle.Bold);
            Font fonteCorpo = new Font("Arial", 10);

            int margemEsquerda = e.MarginBounds.Left;
            int margemSuperior = e.MarginBounds.Top;

            float linhaAltura = fonteCorpo.GetHeight(e.Graphics) + 4;
            float y = margemSuperior;

            // Título
            e.Graphics.DrawString("Relatório de Reserva", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("Data da Reserva", fonteCabecalho, Brushes.Black, margemEsquerda + 50, y);
            e.Graphics.DrawString("ID Equipe", fonteCabecalho, Brushes.Black, margemEsquerda + 250, y);
            e.Graphics.DrawString("ID Equipamento", fonteCabecalho, Brushes.Black, margemEsquerda + 400, y);
            e.Graphics.DrawString("ID Funcionario", fonteCabecalho, Brushes.Black, margemEsquerda + 580, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvReserva.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idReserva"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["dtReserva"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 50, y);
                e.Graphics.DrawString(row.Cells["idEquipe"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["idEquipamento"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 450, y);
                e.Graphics.DrawString(row.Cells["idFunc"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 650, y);

                y += linhaAltura;

                // Evita que ultrapasse a página
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Rodapé ou total opcional
            y += linhaAltura;
            e.Graphics.DrawString("Total de Reserva: " + (dgvReserva.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);

        }

        private void frmRelatorioReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimirRelReserva_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documento;
            preview.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }
    }
}
