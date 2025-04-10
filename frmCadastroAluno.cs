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

        int idAluno = 0;

        public frmCadastroAluno(int idAluno)
        {
            InitializeComponent();
            CarregarEquipeAluno();
            this.idAluno = idAluno;

            if (this.idAluno > 0)
                GetAluno(idAluno);
        }

        private void GetAluno(int idAluno)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from aluno where idAluno=" + idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())

                                {
                                    txtNomeAluno.Text = dr["nomeAluno"].ToString();
                                    txtRgAluno.Text = dr["rgAluno"].ToString();
                                    cmbSexoAluno.Text = dr["sexoAluno"].ToString();
                                    txtCpfAluno.Text = dr["cpfAluno"].ToString();
                                    dtpDataNascimento.Text = dr["dtNascAluno"].ToString();
                                    dtpCadastroAluno.Text = dr["dtCadastroAluno"].ToString();
                                    txtAlturaAluno.Text = dr["alturaAluno"].ToString();
                                    txtPesoAluno.Text = dr["pesoAluno"].ToString();
                                    txtPeBom.Text = dr["pebomAluno"].ToString();
                                    txtPosicaoAluno.Text = dr["posicaoAluno"].ToString();
                                    txtHorarioTreino.Text = dr["horatreinoAluno"].ToString();
                                    txtObservacaoAluno.Text = dr["obsAluno"].ToString();
                                    txtNomeResponsavel.Text = dr["nomeRespAluno"].ToString();
                                    txtRgResponsavel.Text = dr["rgRespAluno"].ToString();
                                    txtCpfResp.Text = dr["cpfRespAluno"].ToString();
                                    txtTelefoneResponsavel.Text = dr["telefoneAluno"].ToString();
                                    txtEnderecoAluno.Text = dr["enderecoAluno"].ToString();
                                    cmbFormaPagamento.Text = dr["formapagAluno"].ToString();
                                    cmbEquipeAluno.Text = dr["equipeAluno"].ToString();
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
                    var sql = "";
                    if (this.idAluno == 0)
                        sql = "Insert into aluno (nomeAluno, sexoAluno, rgALuno, cpfAluno, dtNascAluno, dtCadastroAluno, alturaAluno, pesoAluno, pebomAluno, posicaoAluno, horatreinoAluno, obsAluno, nomeRespAluno, rgRespAluno, cpfRespAluno,telefoneAluno, enderecoAluno, formapagAluno, equipeAluno) VALUES (@nomeAluno, @sexoAluno, @rgAluno, @cpfAluno, @dtNascAluno, @dtCadastro, @altura, @peso, @pebom, @posicao, @horatreino, @obs, @nomeResp, @rgResp, @cpfResp, @telefone, @endereco, @formapag, @equipe)";

                    else
                        sql = "UPDATE aluno set nomeAluno = @nomeAluno, sexoAluno = sexoAluno, rgAluno = @rgAluno, cpfAluno = @cpfAluno, dtNascAluno = @dtNascAluno, dtCadastroAluno = @dtCadastro, alturaAluno = @altura, pesoAluno = @peso, pebomAluno = @pebom, posicaoAluno = @posicao, horatreinoAluno = @horatreino, obsAluno = @obs, nomeRespAluno = @nomeResp, cpfRespAluno = @cpfResp, telefoneAluno = @telefone, enderecoAluno = @endereco, formapagAluno = @formapag, equipeAluno = @equipe";
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

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
    }
}
