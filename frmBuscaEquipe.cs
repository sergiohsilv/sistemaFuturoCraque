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
            this.Hide();
            frmCadastroEquipe frm = new frmCadastroEquipe();
            frm.Show();
        }

        private void btnBuscarEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "SELECT * FROM equipe WHERE subEquipe LIKE @subEquipe OR treinadorEquipe LIKE @treinador OR idEquipe like @idEquipe";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@idEquipe" , "%" + txtBuscarEquipe.Text );
                        cmd.Parameters.AddWithValue("@subEquipe", "%" + txtBuscarEquipe.Text );
                        cmd.Parameters.AddWithValue("@treinador", "%" + txtBuscarEquipe.Text );

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvBuscarEquipe.DataSource = dt;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na Busca de dados\n\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }
    }
}
