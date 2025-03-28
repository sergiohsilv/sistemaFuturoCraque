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
    public partial class frmBuscarReserva : Form
    {
        public frmBuscarReserva()
        {
            InitializeComponent();
        }

        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            frmCadastrarReserva frm = new frmCadastrarReserva();
            frm.ShowDialog();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = @"SELECT er.*, e.nome AS nome_equipamento, f.nome AS nome_funcionario, eq.nome AS nome_equipe
                       FROM EquipamentosReservados er
                       INNER JOIN Equipamentos e ON er.idEquipamento = e.idEquipamento
                       INNER JOIN Funcionarios f ON er.idFuncionario = f.idFuncionario
                       INNER JOIN Equipes eq ON er.idEquipe = eq.idEquipe
                       WHERE 
                           (@idReserva IS NULL OR er.idReserva = @idReserva) AND
                           (@idEquipe IS NULL OR er.idEquipe = @idEquipe) AND
                           (@idFuncionario IS NULL OR er.idFuncionario = @idFuncionario)";


                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscaReserva.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);
            }
        }
    }
}
