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
    
    public partial class frmCadastroEquipamento : Form
    {

        int idEquipamento = 0;
        public frmCadastroEquipamento(int idEquipamento)
        {
            InitializeComponent();
            this.idEquipamento = idEquipamento;

            if (this.idEquipamento > 0)
                GetEquipamento(idEquipamento);
        }

        private void GetEquipamento(int idAluno)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from equipamento where idEquipamento=" + idEquipamento;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())

                                {
                                    txtItemEquipamento.Text = dr["itemEquipamento"].ToString();
                                    txtQtdEquipamento.Text = dr["qtdEquipamento"].ToString();
                                    txtFornecedorEquipamento.Text = dr["fornEquipamento"].ToString();
                                    txtTelefoneEquipamento.Text = dr["telEquipamento"].ToString();
                                    txtSiteEquipamento.Text = dr["siteEquipamento"].ToString();
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

        private void btnCadastroEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "";
                        if (this.idEquipamento == 0)
                        sql = "Insert into equipamento (itemEquipamento, qtdEquipamento, fornEquipamento, telEquipamento, siteEquipamento) VALUES (@item, @qtd, @forn, @telForn, @site)";
                    else
                        sql = "UPDATE equipamento set itemEquipamento = @item, qtdEquipamento = @qtd, fornEquipamento = @forn, telEquipamento = @telForn, siteEquipamento = @site";
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

        private void LimparDisplay(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipamento frm = new frmBuscaEquipamento();
            frm.Show();
        }
    }
}
