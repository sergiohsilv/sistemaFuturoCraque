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
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from alunos where idAluno like '%" + txtBuscarAluno + "%'" +
                        "OR nomeAluno like '%" + txtBuscarAluno + "%'" +
                        "OR rgAluno like '%" + txtBuscarAluno + "%'" +
                        "OR cpfAluno like '%" + txtBuscarAluno + "%'" +
                        "OR nomeRespAluno like '%" + txtBuscarAluno + "%'" +
                        "OR cpfRespAluno like '%" + txtBuscarAluno + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscaAluno.DataSource = dt;
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
