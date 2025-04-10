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
using static sistemaFuturoCraque.frmCadastroAluno;

namespace sistemaFuturoCraque
{
    public partial class frmCadastroEquipe : Form
    {

        int idEquipe = 0;

        public frmCadastroEquipe(int idEquipe)
        {
            InitializeComponent();
            this.idEquipe = idEquipe;

            if (this.idEquipe > 0)
                GetEquipe(idEquipe);
        }

        private void GetEquipe(int idEquipe)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from equipe where idEquipe=" + idEquipe;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())

                                {
                                    txtSubEquipe.Text = dr["subEquipe"].ToString();
                                    txtTreinadorEquipe.Text = dr["treinadorEquipe"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não atualizado .\n\n" + ex.Message);

            }
        }


        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "";
                    if (this.idEquipe == 0)
                        sql = "INSERT INTO equipe (subEquipe, treinadorEquipe) VALUES (@subEquipe, @treinador)";
                    else
                        sql = "UPDATE equipe set subEquipe = @subEquipe, treinadorEquipe = @treinador";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@subEquipe", txtSubEquipe.Text);
                        cmd.Parameters.AddWithValue("@treinador", txtTreinadorEquipe.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não Salvos.\n\n" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipe frm = new frmBuscaEquipe();
            frm.Show();
        }

        private void btnCancelarCadastroEquipe_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
