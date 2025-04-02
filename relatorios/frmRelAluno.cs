using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFuturoCraque.relatorios
{
    public partial class frmRelAluno : Form
    {
        public frmRelAluno()
        {
            InitializeComponent();
        }

        private void frmRelAluno_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
