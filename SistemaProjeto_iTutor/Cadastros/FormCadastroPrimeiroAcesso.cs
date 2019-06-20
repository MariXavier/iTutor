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

            if (perfil == "Professor")
            {
                lbFormacaoAcademica.Visible = true;
                cbFormacaoAcademica.Visible = true;
                txtValorHoraAula.Visible = true;
                lbValorHoraAula.Visible = true;
                lbAsterisco.Visible = true;
                lbAsteriscoValor.Visible = true;
            }
            else
            {
                lbFormacaoAcademica.Visible = false;
                cbFormacaoAcademica.Visible = false;
                txtValorHoraAula.Visible = false;
                lbValorHoraAula.Visible = false;
                lbAsterisco.Visible = false;
                lbAsteriscoValor.Visible = false;
                txtValorHoraAula.Text = String.Empty;
                cbFormacaoAcademica.SelectedIndex = -1;
            }

        }

        private void FormCadastroPrimeiroAcesso_Load(object sender, EventArgs e)
        {
            lbFormacaoAcademica.Visible = false;
            cbFormacaoAcademica.Visible = false;
            txtValorHoraAula.Visible = false;
            lbValorHoraAula.Visible = false;
            lbAsterisco.Visible = false;
            lbAsteriscoValor.Visible = false;

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

            
            //if (VerificarConsistenciaDeTodosOsCampos()) { }



            string perfil = cbPerfilUsuario.SelectedItem.ToString();
            string pkDisciplina = cbFormacaoAcademica.SelectedValue.ToString();

            DateTime myDateTime = DateTime.Now;
            string diaHoraAtual = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            string cpf = AdaptarParametros.adaptarCPF(txtCPF.Text);

            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            query.Parameters.AddWithValue("@nome", txtNome.Text);
            query.Parameters.AddWithValue("@dataNascimento", AdaptarParametros.adaptarCPF(txtNascimento.Text));
            query.Parameters.AddWithValue("@cpf", cpf);
            query.Parameters.AddWithValue("@statusCadastro", 0);
            query.Parameters.AddWithValue("@telefone", AdaptarParametros.adaptarTelefone(txtTelefone.Text));
            query.Parameters.AddWithValue("@email", txtEmail.Text);
            query.Parameters.AddWithValue("@valorHoraAula", txtValorHoraAula.Text);

            query.Parameters.AddWithValue("@cep", AdaptarParametros.adaptarCEP(txtCEP.Text));
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

                query.Parameters.AddWithValue("@levelPermissao", 1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(VerificarConsistenciaDeTodosOsCampos().Length == 0);
            ValidarCampos.VerificarConsistencia(txtNome.Text, AdaptarParametros.adaptarCPF(txtCPF.Text), cbPerfilUsuario.SelectedIndex, "", AdaptarParametros.adaptarCEP(txtCEP.Text), AdaptarParametros.adaptarTelefone(txtTelefone.Text), txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtUsuario.Text, txtSenha.Text, cbPerfilUsuario.SelectedItem.ToString(), cbFormacaoAcademica.SelectedIndex, txtValorHoraAula.Text);
            if(ValidarCampos.camposIncompletos)
            {
                MessageBox.Show(ValidarCampos.respostaFinal);
            }
        }

        public string VerificarConsistenciaDeTodosOsCampos()
        {
            string resposta = "Os seguintes campos precisam ser peenchidos: ";
            int contador = 0;

            if (string.IsNullOrWhiteSpace(txtNome.Text)) { contador++; resposta += "\n - Nome"; }

            if (string.IsNullOrWhiteSpace(AdaptarParametros.adaptarCPF(txtCPF.Text)) || (AdaptarParametros.adaptarCPF(txtCPF.Text)).Length < 11) { contador++; resposta += "\n - CPF"; }

            if (cbPerfilUsuario.SelectedIndex == -1) { contador++; resposta += "\n - Perfil usuário"; }

            if (!txtNascimento.MaskCompleted) { contador++; resposta += "\n - Data de nascimento"; }

            if (string.IsNullOrWhiteSpace(AdaptarParametros.adaptarCEP(txtCEP.Text)) || (AdaptarParametros.adaptarCEP(txtCEP.Text)).Length < 8) { contador++; resposta += "\n - CEP"; }

            if (string.IsNullOrWhiteSpace(AdaptarParametros.adaptarTelefone(txtTelefone.Text)) || (AdaptarParametros.adaptarTelefone(txtTelefone.Text)).Length < 10) { contador++; resposta += "\n - Telefone"; }

            if (string.IsNullOrWhiteSpace(txtRua.Text)) { contador++; resposta += "\n - Rua"; }

            if (string.IsNullOrWhiteSpace(txtNumero.Text)) { contador++; resposta += "\n - Número"; }

            if (string.IsNullOrWhiteSpace(txtBairro.Text)) { contador++; resposta += "\n - Bairro"; }

            if (string.IsNullOrWhiteSpace(txtCidade.Text)) { contador++; resposta += "\n - Cidade"; }

            if (string.IsNullOrWhiteSpace(txtEstado.Text)) { contador++; resposta += "\n - Estado"; }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text)) { contador++; resposta += "\n - Usuário"; }

            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text.Length == 0) { contador++; resposta += "\n - Senha"; }

            if (cbPerfilUsuario.SelectedIndex == -1) { contador++; resposta += "\n - Perfil usuário"; }
            else
            {
                if (cbPerfilUsuario.SelectedItem.ToString() == "Professor")
                {
                    if (cbFormacaoAcademica.SelectedIndex == -1) { contador++; resposta += "\n - Formação acadêmica"; }

                    if (string.IsNullOrWhiteSpace(txtValorHoraAula.Text)) { contador++; resposta += "\n - Valor hora/aula"; }
                }
            }

            if (contador > 0) { return resposta; }
            else { return ""; }

        }

        private void txtNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { e.SuppressKeyPress = true; }
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { e.SuppressKeyPress = true; }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { e.SuppressKeyPress = true; }
        }

        private void txtValorHoraAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }  //Não permitir
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { e.SuppressKeyPress = true; }
        }

        private void TxtNome_Validating(object sender, CancelEventArgs e)
        {
            //TextBox currenttb = (TextBox)sender;
            //if (currenttb.Text == "")
            //{
            //    MessageBox.Show(string.Format("Empty field {0 }", currenttb.Name.Substring(3)));
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //}
        }

        private void lbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




    