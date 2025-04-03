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
    public partial class frmCadastroEquipamento : Form
    {
        public frmCadastroEquipamento()
        {
            InitializeComponent();
        }

        private void btnCadastroEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "Insert into equipamento (itemEquipamento, qtdEquipamento, fornEquipamento, telEquipamento, siteEquipamento) VALUES (@item, @qtd, @forn, @telForn, @site)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@item", txtItemEquipamento.Text);
                        cmd.Parameters.AddWithValue("@qtd", txtQtdEquipamento.Text);
                        cmd.Parameters.AddWithValue("@forn", txtFornecedorEquipamento.Text);
                        cmd.Parameters.AddWithValue("@telForn", txtTelefoneEquipamento.Text);
                        cmd.Parameters.AddWithValue("@site", txtSiteEquipamento.Text);

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
