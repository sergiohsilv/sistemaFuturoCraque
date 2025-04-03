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


        var SqlQuery = @"SELECT r.idReserva, r.dtReserva, r.itemEquipamento, 
                                f.idFunc, e.idEquipe, eq.idEquipamento 
                         FROM reserva r
                         LEFT JOIN funcionario f ON r.idFunc = f.idFunc
                         LEFT JOIN equipe e ON r.idEquipe = e.idEquipe
                         LEFT JOIN equipamento eq ON r.idEquipamento = eq.idEquipamento
                         WHERE r.idReserva LIKE @SearchText 
                            OR r.dtReserva LIKE @SearchText 
                            OR r.itemEquipamento LIKE @SearchText
                            OR f.idFunc LIKE @SearchText
                            OR e.idEquipe LIKE @SearchText
                            OR eq.idEquipamento LIKE @SearchText";

        using (SqlCommand cmd = new SqlCommand(SqlQuery, cn))
        {

            string searchText = "%" + txtBuscarReserva.Text + "%";
            cmd.Parameters.AddWithValue("@SearchText", searchText);


            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvBuscaReserva.DataSource = dt; 
                }
            }
        }
    }
}
catch (Exception ex)
{
    MessageBox.Show("Falha na busca de dados\n\n" + ex.Message);
}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaInicial frm = new frmTelaInicial();
            frm.Show();
        }
    }
}
