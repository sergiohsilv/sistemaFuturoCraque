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
    public partial class frmBuscarJogo : Form
    {
        public frmBuscarJogo()
        {
            InitializeComponent();
        }

        private void btnCadastrarJogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroJogo frm = new frmCadastroJogo(0);
            frm.Show();
        }

        private void btnBuscarJogo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();


                    var SqlQuery = @"SELECT j.idJogo, j.timeadvJogo, j.dataJogo, 
                                j.horaJogo, j.localJogo, j.tempoJogo, e.idEquipe 
                         FROM jogo j
                         LEFT JOIN equipe e ON j.idEquipe = e.idEquipe
                         WHERE j.idjogo LIKE @SearchText 
                            OR j.timeadvJogo LIKE @SearchText 
                            OR j.dataJogo LIKE @SearchText
                            OR j.horaJogo LIKE @SearchText
                            OR j.localJogo LIKE @SearchText
                            OR e.idEquipe LIKE @SearchText
                            OR j.tempoJogo LIKE @SearchText";

                    using (SqlCommand cmd = new SqlCommand(SqlQuery, cn))
                    {

                        string searchText = "%" + txtBuscarJogo.Text + "%";
                        cmd.Parameters.AddWithValue("@SearchText", searchText);


                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dgvBuscarJogo.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na busca de dados\n\n" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }

        private void btnEditarJogo_Click(object sender, EventArgs e)
        {
            if (dgvBuscarJogo.SelectedRows.Count > 0)
            {
                int idJogo = Convert.ToInt32(dgvBuscarJogo.SelectedRows[0].Cells["idJogo"].Value);


                frmCadastroJogo frm = new frmCadastroJogo(idJogo);
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
                    var sqlQuery = "Select * from jogo Where timeadvJogo Like '%" + txtBuscarJogo.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarJogo.DataSource = dt;
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
