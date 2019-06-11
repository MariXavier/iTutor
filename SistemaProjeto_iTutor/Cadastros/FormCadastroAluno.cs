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
using SistemaProjeto_iTutor.Cadastros;
using SistemaProjeto_iTutor.Classes;

namespace SistemaProjeto_iTutor.Cadastros
{
    

    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        int pkAluno = Autenticacao.pkAlunoLogado;

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            if (Autenticacao.levelPermissao == 2) //aluno
            {
                btnExcluir.Visible = false;
                btnLimpar.Visible = false;
                btnSalvar.Visible = false;

                btnAlterar.Location = new Point(681, 346);

                try
                {
                    MessageBox.Show(pkAluno.ToString());
                    string strConexao = Banco.enderecoBanco();
                    string sql = "SELECT a.nome, a.cpf,a.dataNascimento, a.responsavel, a.telefone, e.cep, e.rua, e.numero, e.bairro, e.estado, e.cidade, u.usuario, u.senha, a.pkAluno FROM aluno AS a, endereco AS e, usuario AS u WHERE a.pkAluno = " + pkAluno + " AND e.fkAluno = " + pkAluno + " AND u.fkAluno = " + pkAluno + " AND u.statusCadastro = 0 and a.statusCadastro = 0 ;";
                    SqlConnection conexao = new SqlConnection(strConexao);
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                    DataSet ds = new DataSet();
                    conexao.Open();
                    da.Fill(ds, "aluno");
                    conexao.Close();
                    dgvAluno.DataSource = ds;
                    dgvAluno.DataMember = "aluno";
                    
                    for (int i = 2; i < dgvAluno.Columns.Count; i++)
                    {
                        dgvAluno.Columns[i].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //admin
            {
                try
                {
                    string strConexao = Banco.enderecoBanco();
                    string sql = "select a.nome, a.cpf,a.dataNascimento, a.responsavel, a.telefone, e.cep, e.rua, e.numero, e.bairro, e.estado, e.cidade, u.usuario, u.senha, a.pkAluno from ((aluno as a inner join endereco as e on a.pkAluno = e.fkAluno) inner join  usuario as u on a.pkAluno = u.fkAluno) where u.statusCadastro = 0 and a.statusCadastro = 0;";
                    SqlConnection conexao = new SqlConnection(strConexao);
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                    DataSet ds = new DataSet();
                    conexao.Open();
                    da.Fill(ds, "aluno");
                    conexao.Close();
                    dgvAluno.DataSource = ds;
                    dgvAluno.DataMember = "aluno";

                    for (int i = 2; i < dgvAluno.Columns.Count; i++)
                    {
                        dgvAluno.Columns[i].Visible = false;
                    }

                    //dgvAluno.Columns["dataNascimento"].Visible = false;
                    //dgvAluno.Columns["responsavel"].Visible = false;
                    //dgvAluno.Columns["telefone"].Visible = false;
                    //dgvAluno.Columns["cep"].Visible = false;
                    //dgvAluno.Columns["rua"].Visible = false;
                    //dgvAluno.Columns["numero"].Visible = false;
                    //dgvAluno.Columns["bairro"].Visible = false;
                    //dgvAluno.Columns["estado"].Visible = false;
                    //dgvAluno.Columns["cidade"].Visible = false;
                    //dgvAluno.Columns["usuario"].Visible = false;
                    //dgvAluno.Columns["senha"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.limparComponentes(this);
        }


        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                preencherTextBoxAluno(e);
                pkAluno = Convert.ToInt32(dgvAluno.Rows[e.RowIndex].Cells["pkAluno"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public void preencherTextBoxAluno(DataGridViewCellEventArgs e)
        {
            txtNomeAluno.Text = dgvAluno.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCPF.Text = dgvAluno.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtNomeResponsavel.Text = dgvAluno.Rows[e.RowIndex].Cells["responsavel"].Value.ToString();
            txtDataNascimento.Text = dgvAluno.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
            txtTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtCEP.Text = dgvAluno.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtRua.Text = dgvAluno.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtNumero.Text = dgvAluno.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtCidade.Text = dgvAluno.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtEstado.Text = dgvAluno.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtBairro.Text = dgvAluno.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtUsuario.Text = dgvAluno.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dgvAluno.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            /* =========================================================             
                string textoQuery = "UPDATE aluno SET ";
                if(txtNomeAluno.Text!="") { textoQuery = textoQuery + "nome = @nome"; query.Parameters.AddWithValue("@nome", txtNomeAluno.Text); }
                query.Parameters.AddWithValue("@pkAluno", pkAluno);
                textoQuery += " where pkAluno = @pkAluno and statusCadastro = 0";
                query.CommandText = textoQuery;

         ****** Fazer validação dos campos para que só seja feito update nos campos que estejam preenchidos (!= "")
             =========================================================  */



            query.CommandText = "UPDATE aluno SET nome = @nome, cpf = @cpf, dataNascimento = @dataNascimento, responsavel = @responsavel, telefone = @telefone where pkAluno = @pkAluno and statusCadastro = 0";
            query.Parameters.AddWithValue("@nome", txtNomeAluno.Text);
            query.Parameters.AddWithValue("@dataNascimento", AdaptarParametros.adaptarDataNascimento(txtDataNascimento.Text));
            query.Parameters.AddWithValue("@cpf", AdaptarParametros.adaptarCPF(txtCPF.Text));
            query.Parameters.AddWithValue("@telefone", AdaptarParametros.adaptarTelefone(txtTelefone.Text));
            query.Parameters.AddWithValue("@responsavel", txtNomeResponsavel.Text);
            query.Parameters.AddWithValue("@pkAluno", pkAluno);
            query.ExecuteNonQuery();

            query.CommandText = "UPDATE endereco SET rua = @rua, numero = @numero, cep = @cep, bairro = @bairro, cidade = @cidade, estado = @estado where fkAluno = @pkAluno and statusCadastro = 0";
            query.Parameters.AddWithValue("@rua", txtRua.Text);
            query.Parameters.AddWithValue("@numero",txtNumero.Text);
            query.Parameters.AddWithValue("@cep", AdaptarParametros.adaptarCEP(txtCEP.Text));
            query.Parameters.AddWithValue("@bairro", txtBairro.Text);
            query.Parameters.AddWithValue("@cidade", txtCidade.Text);
            query.Parameters.AddWithValue("@estado", txtEstado.Text);
            query.Parameters.AddWithValue("@fkAluno", pkAluno);
            query.ExecuteNonQuery();

            query.CommandText = "UPDATE usuario SET usuario = @usuario, senha = @senha where fkAluno = @pkAluno and statusCadastro = 0";
            query.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            query.Parameters.AddWithValue("@senha", txtSenha.Text);
            query.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "UPDATE aluno SET statusCadastro = 999 where pkAluno = @pkAluno";
            query.Parameters.AddWithValue("@pkAluno", pkAluno);
            int cont = query.ExecuteNonQuery();

            if (cont > 0)   {  MessageBox.Show("Removido com sucesso"); }
            else            { MessageBox.Show("Erro ao remover"); }
    
            dgvAluno.Update();
            dgvAluno.Refresh();
            conexao.Close();
            Limpar.limparComponentes(this);

            /* =========================================================             
               FAZER O DELETE SETAR O USUARIO COM STATUS 999 TAMBÉM
            =========================================================  */

        }

    }

   
}
