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
            this.Hide();
            frmCadastroAluno frm = new frmCadastroAluno(0);
            frm.Show();

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

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (dgvBuscaAluno.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(dgvBuscaAluno.SelectedRows[0].Cells["idAluno"].Value);

                var confirm = MessageBox.Show("Tem Certeza que deseja Excluir este Aluno?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE * FROM aluno WHERE idAluno = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idAluno);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Aluno excluido com sucesso!");
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

        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "Select * from aluno Where nomeAluno Like '%" + txtBuscarAluno.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscaAluno.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados\n\n" + ex.Message);
            }

        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
         {
             
         }
        

        private void btnEditarAluno_Click_1(object sender, EventArgs e)
        {
          

        }

        private void btnEditarAluno_Click_2(object sender, EventArgs e)
        {
            if (dgvBuscaAluno.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(dgvBuscaAluno.SelectedRows[0].Cells["idAluno"].Value);


                frmCadastroAluno frm = new frmCadastroAluno(idAluno);
                frm.ShowDialog();

                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
