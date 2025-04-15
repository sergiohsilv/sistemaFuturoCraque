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
            frmCadastroFuncionario frm = new frmCadastroFuncionario(0);
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
            if (dgvBuscarFuncionario.SelectedRows.Count > 0)
            {
                int idFunc = Convert.ToInt32(dgvBuscarFuncionario.SelectedRows[0].Cells["idFunc"].Value);


                frmCadastroFuncionario frm = new frmCadastroFuncionario(idFunc);
                frm.ShowDialog();

                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "Select * from funcionario Where idFunc Like '%" + txtBuscarFunc.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarFuncionario.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados\n\n" + ex.Message);
            }

        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            if (dgvBuscarFuncionario.SelectedRows.Count > 0)
            {
                int idFunc = Convert.ToInt32(dgvBuscarFuncionario.SelectedRows[0].Cells["idFunc"].Value);

                var confirm = MessageBox.Show("Tem Certeza que deseja Excluir este Funcionario?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM funcionario WHERE idFunc = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idFunc);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Funcionario excluido com sucesso!");
                                BuscarNovamente();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir aluno \n\n" + ex.Message);
                    }

                }

            }
        }
    }
}
