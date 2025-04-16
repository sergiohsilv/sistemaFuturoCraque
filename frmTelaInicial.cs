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
using sistemaFuturoCraque.relatorios;

namespace sistemaFuturoCraque
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaAluno frm = new frmBuscaAluno();
            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrBuscarFuncionario frm = new fmrBuscarFuncionario();
            frm.Show();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarJogo frm = new frmBuscarJogo();
            frm.Show();
        }

        private void btnCadastroEquipamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipamento frm = new frmBuscaEquipamento();
            frm.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarReserva frm = new frmBuscarReserva();
            frm.Show();
        }

        private void btnEquipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscaEquipe frm = new frmBuscaEquipe();
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height = 182;
                if (menuContainer.Height >= 182)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height = 23;
                if (menuContainer.Height <= 23)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }

        }

        private void btnRelAluno_Click(object sender, EventArgs e)
        {
            DataTable alunos = BuscarAlunos();
            frmRelAluno relatorio = new frmRelAluno();
            relatorio.CarregarDados(alunos);
            relatorio.ShowDialog();
        }

        private DataTable BuscarAlunos()
        {
            string query = "SELECT idAluno, nomeAluno, cpfAluno, equipeAluno FROM aluno";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;

        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transition_Tick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable funcionario = BuscarFuncioanrio();
            frmRelatorioFuncionario relatorio = new frmRelatorioFuncionario();
            relatorio.CarregarDados(funcionario);
            relatorio.ShowDialog();
        }

        private DataTable BuscarFuncioanrio()
        {
            string query = "SELECT idFunc, nomeFunc, cpfFunc, cargoFunc FROM funcionario";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable equipamento = BuscarEquipamento();
            frmRelatorioEquipamento relatorio = new frmRelatorioEquipamento();
            relatorio.CarregarDados(equipamento);
            relatorio.ShowDialog();

        }

        private DataTable BuscarEquipamento()
        {
            string query = "SELECT idEquipamento, itemEquipamento, fornEquipamento, qtdEquipamento FROM equipamento";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;
        }

        private void relEquipe_Click(object sender, EventArgs e)
        {
            DataTable equipe = BuscarEquipe();
            frmRelEquipe relatorio = new frmRelEquipe();
            relatorio.CarregarDados(equipe);
            relatorio.ShowDialog();
        }

        private DataTable BuscarEquipe()
        {
            string query = "SELECT idEquipe, subEquipe, treinadorEquipe FROM equipe";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;
        }

        private void btnRelReserva_Click(object sender, EventArgs e)
        {
            DataTable equipe = BuscarReserva();
            frmRelatorioReserva relatorio = new frmRelatorioReserva();
            relatorio.CarregarDados(equipe);
            relatorio.ShowDialog();

        }

        private DataTable BuscarReserva()
        {
            string query = "SELECT idReserva, dtReserva, idEquipe, idEquipamento, idFunc FROM reserva";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;
        }
    }
}
