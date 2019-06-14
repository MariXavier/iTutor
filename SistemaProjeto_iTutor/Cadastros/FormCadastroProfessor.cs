using SistemaProjeto_iTutor.Classes;
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

namespace SistemaProjeto_iTutor.Cadastros
{
    public partial class FormCadastroProfessor : Form
    {
        public FormCadastroProfessor()
        {
            InitializeComponent();
        }

        int pkProfessor = Autenticacao.pkProfessorLogado;
        int pkProfessorSelecionado = 0;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroProfessor_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT fkDisciplina FROM professor WHERE pkProfessor = "+ pkProfessor + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);

            string pkDisciplina = tabela.Rows[0]["fkDisciplina"].ToString();

            if (Autenticacao.levelPermissao == 1) //professor
            {
                btnExcluir.Visible = false;
                btnLimpar.Visible = false;
                btnSalvar.Visible = false;
                btnAlterar.Location = new Point(627, 390);
                

               // string sql = "select p.nome, p.cpf, d.nome as disciplina, e.cep, e.rua, e.numero, e.bairro, e.cidade, e.estado, p.email, p.valorHoraAula, p.dataNascimento, p.telefone, u.usuario, u.senha from ((professor as p inner join endereco as e on p."+ pkProfessor + " = e." + pkProfessor + ") inner join disciplina as d on p."+ pkDisciplina + " = d." + pkDisciplina + ") inner join usuario as u on p." + pkProfessor + " = u." + pkProfessor + ";";
                string sql = "SELECT p.nome, p.cpf, d.nome as disciplina, e.cep, e.rua, e.numero, e.bairro, e.cidade, e.estado, p.email, p.valorHoraAula, p.dataNascimento, p.telefone, u.usuario, u.senha, p.pkProfessor " +
                    "FROM professor AS p, endereco AS e, usuario AS u, disciplina AS d " +
                    "WHERE p.pkProfessor = " + pkProfessor + " AND e.fkProfessor = " + pkProfessor + " AND u.fkProfessor = " + pkProfessor + " AND d.pkDisciplina = " + pkDisciplina + "; ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                DataSet ds = new DataSet();
                conexao.Open();
                da.Fill(ds, "professor");
                conexao.Close();
                dgvProfessor.DataSource = ds;
                dgvProfessor.DataMember = "professor";

                for (int i = 3; i < dgvProfessor.Columns.Count; i++)
                {
                    dgvProfessor.Columns[i].Visible = false;
                }


            }
            else //admin
            {
                /*select p.nome, p.cpf, d.nome as disciplina, e.cep, e.rua, e.numero, e.bairro, e.cidade, e.estado, p.email, p.valorHoraAula, p.dataNascimento, p.telefone, u.usuario, u.senha  from ((professor as p 
                inner join endereco as e on p.pkProfessor = e.fkProfessor)
                inner join disciplina as d on p.fkDisciplina = d.pkDisciplina)
                inner join usuario as u on p.pkProfessor = u.fkProfessor;*/
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.limparComponentes(this);
        }

        private void dgvProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherTextBoxProfessor(e);
            pkProfessorSelecionado = Convert.ToInt32(dgvProfessor.Rows[e.RowIndex].Cells["pkProfessor"].Value.ToString());
        }

        public void preencherTextBoxProfessor(DataGridViewCellEventArgs e)
        {
            txtNomeProfressor.Text = dgvProfessor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCPFProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            //comboFormacaoProfessor.SelectedValue = dgvProfessor.Rows[e.RowIndex].Cells["disciplina"].Value.ToString();
            txtEmailProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtValorHoraAula.Text = dgvProfessor.Rows[e.RowIndex].Cells["valorHoraAula"].Value.ToString();
            txtNascimentoProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
            txtTelefone.Text = dgvProfessor.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtCEPProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtRua.Text = dgvProfessor.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtNumProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtCidadeProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtEstadoProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtBairroProfessor.Text = dgvProfessor.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtUsuario.Text = dgvProfessor.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dgvProfessor.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }
    }
}
