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
        public frmCadastroEquipe()
        {
        }

        public frmCadastroEquipe(int idEquipe)
        {
            InitializeComponent();
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO equipe (subEquipe, treinadorEquipe) VALUES (@subEquipe, @treinador)";
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
