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
    public partial class frmCadastroJogo : Form
    {

        int idJogo = 0;
            public class ComboboxItem
            {
                public string Text { get; set; }
                public object Value { get; set; }

                public override string ToString()
                {
                    return Text;
                }
            }
            private string connectionString = conexao.IniciarCon;
        public frmCadastroJogo(int idJogo)
        {
            InitializeComponent();
            CarregarEquipe();
            this.idJogo = idJogo;

            if (this.idJogo > 0)
                GetJogo(idJogo);
        }

        private void GetJogo(int idAluno)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from jogo where idJogo=" + idJogo;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())

                                {
                                    txtTimeAdversario.Text = dr["timeadvJogo"].ToString();
                                    dtpDataJogo.Text = dr["dataJogo"].ToString();
                                    txtHorarioJogo.Text = dr["horaJogo"].ToString();
                                    txtLocalJogo.Text = dr["localJogo"].ToString();
                                    txtTempoJogo.Text = dr["tempoJogo"].ToString();
                                    cmbEquipeJogo.Text = dr["idEquipe"].ToString();
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

        private void CarregarEquipe()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEquipe, subEquipe from equipe", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbEquipeJogo.Items.Add(new ComboboxItem
                    {
                        Text = reader["subEquipe"].ToString(),
                        Value = reader["idEquipe"]
                    });
                }
            }
        }

        private void btnCadastrarJogo_Click_1(object sender, EventArgs e)
        {
            int equipeJogo = (int)(cmbEquipeJogo.SelectedItem as ComboboxItem).Value;
            DateTime dtJogo = dtpDataJogo.Value;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "";
                    if (this.idJogo == 0)
                        sql = "Insert into jogo (timeadvJogo, dataJogo, horaJogo, localJogo, tempoJogo, idEquipe) VALUES (@timeadv, @dataJogo, @horaJogo, @local, @tempo, @idEquipe)";
                    else
                        sql = "UPDATE jogo set timeadvJogo = @timeavd , dataJogo = @dataJogo, horaJogo = @horaJogo, localJogo = @local, tempoJogo = @tempo, idEquipe = @idEquipe" + this.idJogo; 
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@timeadv", txtTimeAdversario.Text);
                        cmd.Parameters.AddWithValue("@dataJogo", dtJogo);
                        cmd.Parameters.AddWithValue("@local", txtLocalJogo.Text);
                        cmd.Parameters.AddWithValue("@horaJogo", txtHorarioJogo.Text);
                        cmd.Parameters.AddWithValue("@tempo", txtTempoJogo.Text);
                        cmd.Parameters.AddWithValue("@idEquipe", equipeJogo);


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
            frmBuscarJogo frm = new frmBuscarJogo();
            frm.Show();
        }

        private void btnCancelarCadastroJogo_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
