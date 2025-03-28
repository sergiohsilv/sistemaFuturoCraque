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
    public partial class frmBuscaEquipamento : Form
    {
        public frmBuscaEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadastrarEquipamento_Click(object sender, EventArgs e)
        {
            frmCadastroEquipamento frm = new frmCadastroEquipamento();
            frm.ShowDialog();
        }
    }
}
