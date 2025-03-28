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
    public partial class frmBuscaEquipe : Form
    {
        public frmBuscaEquipe()
        {
            InitializeComponent();
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            frmCadastroEquipe frm = new frmCadastroEquipe();
            frm.ShowDialog();
        }

        private void btnBuscarEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from equipe where subEquipe like '%" + txtBuscarEquipe + "%'" +
                        "OR treinadorEquipe like '%" + txtBuscarEquipe + "%'" +
                        "OR nomeJogadoresEquipe like '%" + txtBuscarEquipe + "%'" +
                        "OR idJogadoresEquipe like '%" + txtBuscarEquipe + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarEquipe.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);
            }
        }
    }
}
