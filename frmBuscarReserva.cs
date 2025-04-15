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


        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try

            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))

                {

                    cn.Open();

                    var sqlQuery = "select * from reserva where idReserva like '%" + txtBuscarReserva.Text + "%'" +
                        "or dtReserva like '%" + txtBuscarReserva.Text + "%'" +
                        "or dtDevolucao like '%" + txtBuscarReserva.Text + "%'" +
                        "or idFunc like '%" + txtBuscarReserva.Text + "%'" +
                        "or idEquipamento like '%" + txtBuscarReserva.Text+ "%'" + 
                        "or idEquipe like '%" + txtBuscarReserva.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }

        private void btnCadastrarReserva_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrarReserva frm = new frmCadastrarReserva(0);
            frm.Show();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (dgvBuscaReserva.SelectedRows.Count > 0)
            {
                int idReserva = Convert.ToInt32(dgvBuscaReserva.SelectedRows[0].Cells["idReserva"].Value);


                frmCadastrarReserva frm = new frmCadastrarReserva(idReserva);
                frm.ShowDialog();

                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            if (dgvBuscaReserva.SelectedRows.Count > 0)
            {
                int idReserva = Convert.ToInt32(dgvBuscaReserva.SelectedRows[0].Cells["idReserva"].Value);

                var confirm = MessageBox.Show("Tem Certeza que deseja Excluir esta Reserva?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM reserva WHERE idReserva = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idReserva);
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
                    var sqlQuery = "Select * from reserva Where dtReserva Like '%" + txtBuscarReserva.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
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
                MessageBox.Show("Erro ao carregar dados\n\n" + ex.Message);
            }

        }
    }
}
