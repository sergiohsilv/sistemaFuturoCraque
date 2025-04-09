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

    public partial class frmCadastroAluno : Form
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

        public frmCadastroAluno()
        {
            InitializeComponent();
            CarregarEquipeAluno();
        }



        private void CarregarEquipeAluno()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEquipe, subEquipe from equipe", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbEquipeAluno.Items.Add(new ComboboxItem
                    {
                        Text = reader["subEquipe"].ToString(),
                        Value = reader["idEquipe"]
                    });
                }
            }
        }

        private void btnCadastarAluno_Click(object sender, EventArgs e)
        {
            int equipeAluno = (int)(cmbEquipeAluno.SelectedItem as ComboboxItem).Value;
            DateTime dtNascAluno = dtpDataNascimento.Value;
            DateTime dtCadastroAluno = dtpCadastroAluno.Value;
            string sexoAluno = cmbSexoAluno.SelectedItem.ToString();
            string formapagAluno = cmbFormaPagamento.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "Insert into aluno (nomeAluno, sexoAluno, rgALuno, cpfAluno, dtNascAluno, dtCadastroAluno, alturaAluno, pesoAluno, pebomAluno, posicaoAluno, horatreinoAluno, obsAluno, nomeRespAluno, rgRespAluno, cpfRespAluno,telefoneAluno, enderecoAluno, formapagAluno, equipeAluno) VALUES (@nomeAluno, @sexoAluno, @rgAluno, @cpfAluno, @dtNascAluno, @dtCadastro, @altura, @peso, @pebom, @posicao, @horatreino, @obs, @nomeResp, @rgResp, @cpfResp, @telefone, @endereco, @formapag, @equipe)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeAluno", txtNomeAluno.Text);
                        cmd.Parameters.AddWithValue("@sexoAluno", sexoAluno);
                        cmd.Parameters.AddWithValue("@rgAluno", txtRgAluno.Text);
                        cmd.Parameters.AddWithValue("@cpfAluno", txtCpfAluno.Text);
                        cmd.Parameters.AddWithValue("@dtNascAluno", dtNascAluno);
                        cmd.Parameters.AddWithValue("@dtCadastro", dtCadastroAluno);
                        cmd.Parameters.AddWithValue("@altura", txtAlturaAluno.Text);
                        cmd.Parameters.AddWithValue("@peso", txtPesoAluno.Text);
                        cmd.Parameters.AddWithValue("@pebom", txtPeBom.Text);
                        cmd.Parameters.AddWithValue("@posicao", txtPosicaoAluno.Text);
                        cmd.Parameters.AddWithValue("@horatreino", txtHorarioTreino.Text);
                        cmd.Parameters.AddWithValue("@obs", txtObservacaoAluno.Text);
                        cmd.Parameters.AddWithValue("@nomeResp", txtNomeResponsavel.Text);
                        cmd.Parameters.AddWithValue("@rgResp", txtRgResponsavel.Text);
                        cmd.Parameters.AddWithValue("@cpfResp", txtCpfResp.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefoneResponsavel.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEnderecoAluno.Text);
                        cmd.Parameters.AddWithValue("@formapag", formapagAluno);
                        cmd.Parameters.AddWithValue("@equipe", equipeAluno);

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
            frmBuscaAluno frm = new frmBuscaAluno();
            frm.Show();
        }

        public static class FormUtils
        {
            public static void LimparCampos(Control container)
            {
                foreach (Control control in container.Controls)
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)control).Clear();
                    }
                    else if (control is System.Windows.Forms.ComboBox)
                    {
                        ((System.Windows.Forms.ComboBox)control).SelectedIndex = -1;
                    }
                    if (control.HasChildren)
                    {
                        LimparCampos(control);
                    }
                }
            }
        }

        private void btnCancelarCadastroAluno_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
