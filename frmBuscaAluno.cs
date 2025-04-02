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
                    var sqlQuery = "SELECT * FROM aluno WHERE idAluno LIKE @idAluno OR nomeAluno LIKE @nomeAluno OR cpfAluno like @cpfAluno OR nomeRespAluno like @nomeResp";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@idAluno", "%" + txtBuscarAluno.Text + "%");
                        cmd.Parameters.AddWithValue("@nomeAluno", "%" + txtBuscarAluno.Text + "%");
                        cmd.Parameters.AddWithValue("@cpfAluno", "%" + txtBuscarAluno.Text + "%");
                        cmd.Parameters.AddWithValue("@nomeResp", "%" + txtBuscarAluno.Text + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
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
