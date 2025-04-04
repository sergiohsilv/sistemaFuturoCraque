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
            this.Hide();
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.Show();
        }

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "SELECT * FROM funcionario WHERE idFunc LIKE @idFunc OR nomeFunc LIKE @nomeFunc OR cargoFunc like @cargoFunc";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@idFunc", "%" + txtBuscarFunc.Text + "%");
                        cmd.Parameters.AddWithValue("@nomeFunc", "%" + txtBuscarFunc.Text + "%");
                        cmd.Parameters.AddWithValue("@cargoFunc", "%" + txtBuscarFunc.Text + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
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

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {

        }
    }
}
