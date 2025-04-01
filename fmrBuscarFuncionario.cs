using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from funcionario where idFunc like '%" + txtBuscarFunc + "%'" +
                        "OR nomeFunc like '%" + txtBuscarFunc + "%'" +
                        "OR rgFunc like '%" + txtBuscarFunc + "%'" +
                        "OR cpfFunc like '%" + txtBuscarFunc + "%'" +
                        "OR emailFunc like '%" + txtBuscarFunc + "%'" +
                        "OR cargoFunc like '%" + txtBuscarFunc + "%'" +
                        "OR usuarioFunc like '%" + txtBuscarFunc + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarFuncionario.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na busca\n\n" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }
    }
}
