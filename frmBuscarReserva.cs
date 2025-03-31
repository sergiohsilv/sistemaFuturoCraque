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
    public partial class frmBuscarReserva : Form
    {
        public frmBuscarReserva()
        {
            InitializeComponent();
        }

        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            frmCadastrarReserva frm = new frmCadastrarReserva();
            frm.ShowDialog();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from reserva where idReserva like '%" + txtBuscarReserva + "%'" +
                        "OR dtReserva like '%" + txtBuscarReserva + "%'" +
                        "OR itemEquipamento like '%" + txtBuscarReserva + "%'" +
                        "OR idFunc like '%" + txtBuscarReserva + "%'" +
                        "OR idEquipe like '%" + txtBuscarReserva + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscaReserva.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na busca\n\n" + ex.Message);
            }
        }
    }
}
