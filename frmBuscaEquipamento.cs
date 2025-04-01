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

        private void btnBuscarEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "Select*from equipamento where idEquipamento like '%" + txtBuscaEquipamento + "%'" +
                        "OR itemEquipamento like '%" + txtBuscaEquipamento + "%'" +
                        "OR fornEquipamento like '%" + txtBuscaEquipamento + "%'" +
                        "OR telEquipamento like '%" + txtBuscaEquipamento + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarEquipamento.DataSource = dt;
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
