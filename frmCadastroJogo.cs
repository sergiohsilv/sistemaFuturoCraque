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
    public partial class frmCadastroJogo : Form
    {
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
        public frmCadastroJogo()
        {
            InitializeComponent();
            CarregarEquipe();
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
                    var sql = "Insert into jogo (timeadvJogo, dataJogo, horaJogo, localJogo, tempoJogo, idEquipe) VALUES (@timeadv, @dataJogo, @horaJogo, @local, @tempo, @idEquipe)";
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
    }
}
