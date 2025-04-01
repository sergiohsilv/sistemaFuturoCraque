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
    public partial class frmBuscarJogo : Form
    {
        public frmBuscarJogo()
        {
            InitializeComponent();
        }

        private void btnCadastrarJogo_Click(object sender, EventArgs e)
        {
            frmCadastroJogo frm = new frmCadastroJogo();
            frm.ShowDialog();
        }

        private void btnBuscarJogo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from jogo where idJogo like '%" + txtBuscarJogo + "%'" +
                        "OR timeadvJogo like '%" + txtBuscarJogo + "%'" +
                        "OR subJogo like '%" + txtBuscarJogo + "%'" +
                        "OR idEquipe like '%" + txtBuscarJogo + "%'" +
                        "OR localJogo like '%" + txtBuscarJogo + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarJogo.DataSource = dt;
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
