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
                    var SqlQuery = "Select e.idEquipe FROM equipe a JOIN reserva r ON e.idEquipe = r.idEquipe WHERE like '%" + txtBuscarReserva.Text + "%'" +
                        "Select eq.idEquipamento FROM equipamento a JOIN reserva r ON eq.idEquipamento = r.idEquipamento WHERE like '%" + txtBuscarReserva.Text + "%'" +
                        "Select f.idFunc FROM funcionario a JOIN reserva r ON f.idFunc = r.idFunc WHERE like '%" + txtBuscarReserva.Text + "%'" +
                        "OR ridReserva like '%" + txtBuscarReserva.Text + "%'" +
                        "OR dtReserva like '%" + txtBuscarReserva.Text + "%'" +
                        "OR dtDevolucao like '%" + txtBuscarReserva.Text + "%'" +
                        "OR qtdEquipamento like '%" + txtBuscarReserva.Text + "%'" +
                        "OR itemEquipamento like '%" + txtBuscarReserva.Text + "%'";


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
                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);
            }
        }
    }
}
