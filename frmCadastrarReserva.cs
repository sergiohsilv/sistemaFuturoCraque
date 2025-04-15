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
    public partial class frmCadastrarReserva : Form
    {

        int idReserva = 0;

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

        public frmCadastrarReserva(int idReserva)
        {
            InitializeComponent();
            CarregarEquipe();
            CarregarFunc();
            CarregarEquipamento();
            this.idReserva = idReserva;

            if (this.idReserva > 0)
                GetReserva(idReserva);
        }



        private void GetReserva(int idReserva)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from reserva where idReserva=" + idReserva;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    dtpReserva.Text = dr["dtReserva"].ToString();
                                    dtpDevolucao.Text = dr["dtDevolucao"].ToString();
                                    txtQuantidadeEquipamento.Text = dr["qtdEquipamento"].ToString();
                                    cmbEquipe.Text = dr["idEquipe"].ToString();
                                    cmbEquipamento.Text = dr["idEquipamento"].ToString();
                                    cmbFuncionario.Text = dr["idFunc"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não Atualizados . \n\n" + ex.Message);
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
                    cmbEquipe.Items.Add(new ComboboxItem
                    {
                        Text = reader["subEquipe"].ToString(),
                        Value = reader["idEquipe"]
                    });
                }
            }
        }

        private void CarregarFunc()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idFunc, nomeFunc from funcionario", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbFuncionario.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeFunc"].ToString(),
                        Value = reader["idFunc"]
                    });
                }
            }
        }

        private void CarregarEquipamento()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEquipamento, itemEquipamento from equipamento", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbEquipamento.Items.Add(new ComboboxItem
                    {
                        Text = reader["itemEquipamento"].ToString(),
                        Value = reader["idEquipamento"]
                    });
                }
            }
        }



        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            int equipeReserva = (int)(cmbEquipe.SelectedItem as ComboboxItem).Value;
            int nomeFunc = (int)(cmbFuncionario.SelectedItem as ComboboxItem).Value;
            int itemEquipamento = (int)(cmbEquipamento.SelectedItem as ComboboxItem).Value;
            DateTime dtReserva = dtpReserva.Value;
            DateTime dtDevolucao = dtpDevolucao.Value;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {

                    cn.Open();
                    var sql = "";
                    if (this.idReserva == 0)
                        sql = "Insert into reserva (dtReserva , dtDevolucao, qtdEquipamento, idEquipe, idEquipamento, idFunc) VALUES (@dtReserva, @dtDevolucao,@qtdEquipamento, @idEquipe, @idItem, @idFunc)";
                    else
                        sql = "update reserva set dtReserva = @dtReserva, dtDevolucao = @dtDevolucao, qtdEquipamento = @qtdEquipamento , idEquipe = @idEquipe, idEquipamento = @idItem, idFunc = @idFunc where idReserva =" + this.idReserva;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@dtReserva", dtReserva);
                        cmd.Parameters.AddWithValue("@dtDevolucao", dtDevolucao);
                        cmd.Parameters.AddWithValue("@qtdEquipamento", txtQuantidadeEquipamento.Text);
                        cmd.Parameters.AddWithValue("@idEquipe", equipeReserva);
                        cmd.Parameters.AddWithValue("@idItem", itemEquipamento);
                        cmd.Parameters.AddWithValue("@idFunc", nomeFunc);

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
            frmBuscaEquipamento frm = new frmBuscaEquipamento();
            frm.Show();
        }

        private void LimparDisplay(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
