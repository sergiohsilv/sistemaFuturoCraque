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
    public partial class frmCadastroFuncionario : Form
    {
        int idFuncionario = 0;
        public frmCadastroFuncionario(int idFuncioanrio)
        {
            InitializeComponent();
            this.idFuncionario = idFuncioanrio;

            if (this.idFuncionario > 0)
                GetFuncionario(idFuncionario);
        }

        private void GetFuncionario(int idFuncionario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from funcionario where idFunc=" + idFuncionario;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())

                                {
                                    txtNomeCompletoFunc.Text = dr["nomeFunc"].ToString();
                                    dtpCadastroFunc.Text = dr["dtCadastroFunc"].ToString();
                                    cmbSexoFunc.Text = dr["sexoFunc"].ToString();
                                    txtRgFunc.Text = dr["rgFunc"].ToString();
                                    txtCpfFunc.Text = dr["cpfFunc"].ToString();
                                    dtpDataNascimentoFunc.Text = dr["dataNascFunc"].ToString();
                                    txtCargoFunc.Text = dr["cargoFunc"].ToString();
                                    txtNomeUsuarioFunc.Text = dr["usuarioFunc"].ToString();
                                    txtSenhaFunc.Text = dr["senhaFunc"].ToString();
                                    txtEmailFunc.Text = dr["emailFunc"].ToString();
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


        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            string sexoFunc = cmbSexoFunc.SelectedItem.ToString();
            DateTime dtNacsFunc = dtpDataNascimentoFunc.Value;
            DateTime dtCadastroFunc = dtpCadastroFunc.Value;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "";
                    if(this.idFuncionario == 0)
                        sql = "Insert into funcionario (nomeFunc, dtCadastroFunc, sexoFunc, rgFunc, cpfFunc, dataNascFunc, cargoFunc, usuarioFunc, senhaFunc, emailFunc) VALUES (@nomeFunc, @dtCadastroFunc, @sexoFunc, @rgFunc, @cpfFunc, @dtNascFunc, @cargoFunc, @usuarioFunc, @senhaFunc, @emailFunc)";
                    else
                        sql = "UPDATE funcionario set nomeFunc = @nomeFunc, dtCadastroFunc = @dtCadastroFunc, sexoFunc = @sexoFunc, rgFunc = @rgFunc, cpfFunc = @cpfFunc, dataNascFunc = @dtNascFunc, cargoFunc = @cargoFunc usuarioFunc = @usuarioFunc, senhaFunc = @senhaFunc, emailFunc = @emailFunc where idFunc ="+ this.idFuncionario; 
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeFunc", txtNomeCompletoFunc.Text);
                        cmd.Parameters.AddWithValue("dtCadastroFunc", dtCadastroFunc);
                        cmd.Parameters.AddWithValue("@sexoFunc", sexoFunc);
                        cmd.Parameters.AddWithValue("@rgFunc", txtRgFunc.Text);
                        cmd.Parameters.AddWithValue("@cpfFunc", txtCpfFunc.Text);
                        cmd.Parameters.AddWithValue("@dtNascFunc", dtNacsFunc);
                        cmd.Parameters.AddWithValue("@cargoFunc", txtCargoFunc.Text);
                        cmd.Parameters.AddWithValue("@emailFunc", txtEmailFunc.Text);
                        cmd.Parameters.AddWithValue("usuarioFunc", txtNomeUsuarioFunc.Text);
                        cmd.Parameters.AddWithValue("@senhaFunc", txtSenhaFunc.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso");
                    }                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não Salvos.\n\n" + ex.Message);
            }
        }

        private void btnCancelarCadastroFunc_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrBuscarFuncionario frm = new fmrBuscarFuncionario();
            frm.Show();
        }
    }
}
