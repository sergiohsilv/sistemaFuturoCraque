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
    public partial class frmBuscaAluno : Form
    {
        public frmBuscaAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frm = new frmCadastroAluno();
            frm.ShowDialog();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {

        }
    }
}
