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
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
