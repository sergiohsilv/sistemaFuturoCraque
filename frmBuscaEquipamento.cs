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
            frmCadastroEquipamento frm = new frmCadastroEquipamento(0);
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

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            if (dgvBuscarEquipamento.SelectedRows.Count > 0)
            {
                int idEquipamento = Convert.ToInt32(dgvBuscarEquipamento.SelectedRows[0].Cells["idEquipamento"].Value);


                frmCadastroEquipamento frm = new frmCadastroEquipamento(idEquipamento);
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
                    var sqlQuery = "Select * from equipamento Where itemEquipamemto Like '%" + txtBuscaEquipamento.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
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
                MessageBox.Show("Erro ao carregar dados\n\n" + ex.Message);
            }

        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            if (dgvBuscarEquipamento.SelectedRows.Count > 0)
            {
                int idEquipamento = Convert.ToInt32(dgvBuscarEquipamento.SelectedRows[0].Cells["idEquipamento"].Value);

                var confirm = MessageBox.Show("Tem Certeza que deseja Excluir este Equipamento?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM equipamento WHERE idEquipamento = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idEquipamento);
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
    }
}
