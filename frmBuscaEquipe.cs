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
            frmCadastroEquipe frm = new frmCadastroEquipe(0);
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
                        cmd.Parameters.AddWithValue("@idEquipe", "%" + txtBuscarEquipe.Text);
                        cmd.Parameters.AddWithValue("@subEquipe", "%" + txtBuscarEquipe.Text);
                        cmd.Parameters.AddWithValue("@treinador", "%" + txtBuscarEquipe.Text);

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

        private void btnEditarEquipe_Click(object sender, EventArgs e)
        {
            if (dgvBuscarEquipe.SelectedRows.Count > 0)
            {
                int idEquipe = Convert.ToInt32(dgvBuscarEquipe.SelectedRows[0].Cells["idEquipe"].Value);


                frmCadastroEquipe frm = new frmCadastroEquipe(idEquipe);
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
                    var sqlQuery = "Select * from equipe Where subEquipe Like '%" + txtBuscarEquipe.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
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
                MessageBox.Show("Erro ao carregar dados\n\n" + ex.Message);
            }
        }

        private void btnExcluirEquipe_Click(object sender, EventArgs e)
        {
            if (dgvBuscarEquipe.SelectedRows.Count > 0)
            {
                int idEquipe = Convert.ToInt32(dgvBuscarEquipe.SelectedRows[0].Cells["idEquipe"].Value);

                var confirm = MessageBox.Show("Tem Certeza que deseja Excluir esta Equipe?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE  FROM equipe WHERE idEquipe = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idEquipe);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Equipe excluida com sucesso!");
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
