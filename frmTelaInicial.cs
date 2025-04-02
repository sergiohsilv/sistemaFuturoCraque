using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaFuturoCraque.relatorios;

namespace sistemaFuturoCraque
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaAluno frm = new frmBuscaAluno();
            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrBuscarFuncionario frm = new fmrBuscarFuncionario();
            frm.Show();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarJogo frm = new frmBuscarJogo();
            frm.Show();
        }

        private void btnCadastroEquipamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipamento frm = new frmBuscaEquipamento();
            frm.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarReserva frm = new frmBuscarReserva();
            frm.Show();
        }

        private void btnEquipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipe frm = new frmBuscaEquipe();
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelAluno frm = new frmRelAluno();
            frm.ShowDialog();
        }
    }
}
