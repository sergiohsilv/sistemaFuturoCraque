using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFuturoCraque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }

                if (AutenticarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    this.Hide();
                    var formPrincipal = new frmTelaInicial();
                    formPrincipal.Show();
                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show ($"Erro ao acessar o banco de dados: \n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: \n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private bool AutenticarUsuario(string usuario, string senha)
        {
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            {
                string query = "Select idUsuario FROM usuarios WHERE nomeUsuario = @usuario AND senhaUsuario = @senha";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    return result != null && result != DBNull.Value;
                }
            }
        }
    }
}
