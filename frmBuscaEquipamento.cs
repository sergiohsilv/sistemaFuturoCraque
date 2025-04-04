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
            this.Hide();
            frmCadastroEquipamento frm = new frmCadastroEquipamento();
            frm.Show();
        }

        private void btnBuscarEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "SELECT * FROM equipamento WHERE idEquipamento LIKE @idEquipamento OR itemEquipamento LIKE @item OR fornEquipamento like @forn";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@idEquipamento", "%" + txtBuscaEquipamento.Text);
                        cmd.Parameters.AddWithValue("@item", "%" + txtBuscaEquipamento.Text);
                        cmd.Parameters.AddWithValue("@forn", "%" + txtBuscaEquipamento.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvBuscarEquipamento.DataSource = dt;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na Busca de dados\n\n" + ex.Message);
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
