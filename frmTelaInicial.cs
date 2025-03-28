using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmBuscaAluno frm = new frmBuscaAluno();
            frm.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            fmrBuscarFuncionario frm = new fmrBuscarFuncionario();
            frm.ShowDialog();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            frmBuscarJogo frm = new frmBuscarJogo();
            frm.ShowDialog();
        }

        private void btnCadastroEquipamentos_Click(object sender, EventArgs e)
        {
            frmBuscaEquipamento frm = new frmBuscaEquipamento();
            frm.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmBuscarReserva frm = new frmBuscarReserva();
            frm.ShowDialog();
        }

        private void btnEquipes_Click(object sender, EventArgs e)
        {
            frmBuscaEquipe frm = new frmBuscaEquipe();
            frm.ShowDialog();
        }
    }
}
