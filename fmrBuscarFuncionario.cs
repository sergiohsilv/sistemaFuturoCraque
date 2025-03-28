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
    public partial class fmrBuscarFuncionario : Form
    {
        public fmrBuscarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastarFunc_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.ShowDialog();
        }
    }
}
