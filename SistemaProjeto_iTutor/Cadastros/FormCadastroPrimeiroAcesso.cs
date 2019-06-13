using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaProjeto_iTutor.Classes;

namespace SistemaProjeto_iTutor.Cadastros
{
    public partial class FormCadastroPrimeiroAcesso : Form
    {
        public FormCadastroPrimeiroAcesso()
        {
            InitializeComponent();
        }

        private void cbPerfilUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string perfil = cbPerfilUsuario.SelectedItem.ToString();

            if(perfil == "Professor")
            {
                lbFormacaoAcademica.Visible = true;
                cbFormacaoAcademica.Visible = true;
                txtValorHoraAula.Visible = true;
                lbValorHoraAula.Visible = true;
            }
            else
            {
                lbFormacaoAcademica.Visible = false;
                cbFormacaoAcademica.Visible = false;
                txtValorHoraAula.Visible = false;
                lbValorHoraAula.Visible = false;
            }
            
        }

        private void FormCadastroPrimeiroAcesso_Load(object sender, EventArgs e)
        {
            lbFormacaoAcademica.Visible = false;
            cbFormacaoAcademica.Visible = false;
            txtValorHoraAula.Visible = false;
            lbValorHoraAula.Visible = false;

            SqlConnection conn = new SqlConnection(Banco.enderecoBanco());
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM disciplina", conn);

            SqlDataReader reader;
            
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("nome");
            dt.Load(reader);

            cbFormacaoAcademica.ValueMember = "pkDisciplina";
            cbFormacaoAcademica.DisplayMember = "nome";
            cbFormacaoAcademica.DataSource = dt;

            conn.Close();
        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Replace("-", "");

            if (cep.Length == 8)
            {
                try
                {
                    var webService = new WSCorreios.AtendeClienteClient();
                    var resposta = webService.consultaCEP(txtCEP.Text);
                    txtRua.Text = resposta.end;
                    txtBairro.Text = resposta.bairro;
                    txtCidade.Text = resposta.cidade;
                    txtEstado.Text = resposta.uf;
                }
                catch (Exception)
                {
                    MessageBox.Show("CEP não localizado");
                }
            }
            else
            {
                MessageBox.Show("Informe um valor de CEP válido");
            }

        }

        private void txtCEP_Click(object sender, EventArgs e)
        {
            txtCEP.SelectionStart = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string perfil = cbPerfilUsuario.SelectedItem.ToString();
            string pkDisciplina = cbFormacaoAcademica.SelectedValue.ToString();

            string cpf = (txtCPF.Text).Trim().Replace(",", "").Replace("-", "");
            
            string dia = txtNascimento.Text.Substring(0, 2);
            string mes = txtNascimento.Text.Substring(3, 2);
            string ano = txtNascimento.Text.Substring(6, 4);
            string dataNascimento = ano + "-" + mes + "-" + dia;

            string telefone = (txtTelefone.Text).Trim().Replace(")", "").Replace("(", "");

            string cep = (txtCEP.Text).Trim().Replace("-", "");

            DateTime myDateTime = DateTime.Now;
            string diaHoraAtual = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            query.Parameters.AddWithValue("@nome", txtNome.Text);
            query.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            query.Parameters.AddWithValue("@cpf", cpf);
            query.Parameters.AddWithValue("@statusCadastro", 0);
            query.Parameters.AddWithValue("@telefone", telefone);
            query.Parameters.AddWithValue("@email", txtEmail.Text);
            query.Parameters.AddWithValue("@valorHoraAula", txtValorHoraAula.Text);

            query.Parameters.AddWithValue("@cep", cep);
            query.Parameters.AddWithValue("@rua", txtRua.Text);
            query.Parameters.AddWithValue("@numero", txtNumero.Text);
            query.Parameters.AddWithValue("@bairro", txtBairro.Text);
            query.Parameters.AddWithValue("@cidade", txtCidade.Text);
            query.Parameters.AddWithValue("@estado", txtEstado.Text);

            query.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            query.Parameters.AddWithValue("@senha", txtSenha.Text);
            query.Parameters.AddWithValue("@dataCriacao", Convert.ToDateTime(diaHoraAtual));
            query.Parameters.AddWithValue("@solicitacaoAprovada", 1);

            if (perfil == "Professor")
            {
                query.Parameters.AddWithValue("@fkDisciplina", pkDisciplina);
                query.CommandText = "INSERT INTO professor (nome, dataNascimento, cpf, statusCadastro, telefone, email, fkDisciplina, valorHoraAula) values (@nome, @dataNascimento, @cpf, @statusCadastro, @telefone, @email, @fkDisciplina, @valorHoraAula)";
                query.ExecuteNonQuery();

                query.CommandText = "SELECT pkProfessor FROM professor where cpf = '" + cpf + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(query);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                query.ExecuteNonQuery();
                
                int pkProfessor = Convert.ToInt32(tabela.Rows[0]["pkProfessor"].ToString());
                query.Parameters.AddWithValue("@fkProfessor", pkProfessor);
                query.Parameters.AddWithValue("@fkAluno", DBNull.Value); 
                query.CommandText = "INSERT INTO endereco (cep, rua, numero, bairro, cidade, estado, statusCadastro, fkAluno, fkProfessor) VALUES (@cep, @rua, @numero, @bairro, @cidade, @estado, @statusCadastro,@fkAluno, @fkProfessor)";           
                query.ExecuteNonQuery();

                query.Parameters.AddWithValue("@levelPermissao",1);
                query.CommandText = "INSERT INTO usuario (usuario, senha, levelPermissao, dataCriacao, solicitacaoAprovada, statusCadastro,fkAluno, fkProfessor) VALUES (@usuario, @senha, @levelPermissao, @dataCriacao, @solicitacaoAprovada, @statusCadastro,@fkAluno, @fkProfessor)";
                query.ExecuteNonQuery();
            }
            else
            {
                query.CommandText = "INSERT INTO aluno (nome, dataNascimento, cpf, statusCadastro, telefone, email) values (@nome, @dataNascimento, @cpf, @statusCadastro, @telefone, @email)";
                query.ExecuteNonQuery();

                query.CommandText = "SELECT pkAluno FROM aluno WHERE cpf = '" + cpf + "'";
                DataTable tabela = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query);
                adaptador.Fill(tabela);
                query.ExecuteNonQuery();

                int pkAluno = Convert.ToInt32(tabela.Rows[0]["pkAluno"].ToString());
                query.Parameters.AddWithValue("@fkProfessor", DBNull.Value);
                query.Parameters.AddWithValue("@fkAluno", pkAluno);
                query.CommandText = "INSERT INTO endereco (cep, rua, numero, bairro, cidade, estado, statusCadastro, fkAluno, fkProfessor) VALUES (@cep, @rua, @numero, @bairro, @cidade, @estado, @statusCadastro, @fkAluno, @fkProfessor)";
                query.ExecuteNonQuery();

                query.Parameters.AddWithValue("@levelPermissao", 2);
                query.CommandText = "INSERT INTO usuario (usuario, senha, levelPermissao, dataCriacao, solicitacaoAprovada, statusCadastro,fkAluno, fkProfessor) VALUES (@usuario, @senha, @levelPermissao, @dataCriacao, @solicitacaoAprovada, @statusCadastro,@fkAluno, @fkProfessor)";
                query.ExecuteNonQuery();
            }

            conexao.Close();
        }

        private void cbFormacaoAcademica_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
           
        }
    }
}




