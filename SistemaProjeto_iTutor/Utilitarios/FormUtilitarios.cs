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


namespace SistemaProjeto_iTutor.Utilitarios
{
    public partial class FormUtilitarios : Form
    {
        public FormUtilitarios()
        {
            InitializeComponent();
        }

        string pkUser;
        
        private void FormUtilitarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iTutorDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.iTutorDataSet.usuario);

           
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.limparComponentes(this);
        }


        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                preencherTextBoxUsuario(e);
                //usuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["pkUsuario"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void preencherTextBoxUsuario(DataGridViewCellEventArgs e)
        {
            pkUser = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtData.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUser.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            string status = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (status == "0") {
                cbxStatusCadastro.SelectedValue = "Ativo";
            }
            else
            {
                cbxStatusCadastro.SelectedValue = "Inativo";
            }

           

            string permissao = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (permissao == "0")
            {
                rbnAdministrador.Checked = true;
            }else if (permissao == "1")
            {
                rbnProfessor.Checked = true;
            }
            else
            {
                rbnAluno.Checked = true;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            int status;
            int perfil;
                        
            if (rbnAdministrador.Checked == true)
            {
                perfil = 0;
            }else if (rbnAluno.Checked == true)
            {
                perfil = 2;
            }
            else
            {
                perfil = 1;
            }

            if (cbxStatusCadastro.ToString() == "Ativo")
            {
                status = 0;
            }
            else
            {
                status = 999;
            }
                        
            query.CommandText = "UPDATE usuario SET usuario = @usuario, senha = @senha, statusCadastro = @status, levelPermissao = @perfil where pkUsuario = @pkUsuario";
            query.Parameters.AddWithValue("@usuario", txtUser.Text);
            query.Parameters.AddWithValue("@senha", txtSenha.Text);
            query.Parameters.AddWithValue("@perfil", perfil);
            query.Parameters.AddWithValue("@pkUsuario", pkUser);
            query.Parameters.AddWithValue("@status", status);
            int cont = query.ExecuteNonQuery();

            if (cont > 0) { MessageBox.Show("Cadastro Alterado com Sucesso"); }
            else { MessageBox.Show("Erro"); }

            conexao.Close();
            FormUtilitarios_Load(null, null);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            string diaHoraAtual = localDate.ToString();
            
            int perfil;

            txtData.Text = diaHoraAtual;

            if (rbnAdministrador.Checked == true)
            {
                perfil = 0;
            }
            else if (rbnAluno.Checked == true)
            {
                perfil = 2;
            }
            else
            {
                perfil = 1;
            }

            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand query = new SqlCommand();

            query.Connection = conexao;
            conexao.Open();

            query.Parameters.AddWithValue("@usuario", txtUser.Text);
            query.Parameters.AddWithValue("@senha", txtSenha.Text);
            query.Parameters.AddWithValue("@dataCriacao", diaHoraAtual);
            query.Parameters.AddWithValue("@statusCadastro", 0);
            query.Parameters.AddWithValue("@levelPermissao", perfil);
            query.Parameters.AddWithValue("@solicitacaoAprovada", 1);

            query.CommandText = "INSERT INTO usuario (usuario, senha, dataCriacao, statusCadastro, levelPermissao, solicitacaoAprovada) values (@usuario, @senha, @dataCriacao, @statusCadastro, @levelPermissao, @solicitacaoAprovada)";
            int cont = query.ExecuteNonQuery();

            if (cont > 0) { MessageBox.Show("Cadastro Realizado com Sucesso"); }
            else { MessageBox.Show("Erro ao Cadastrar"); }
            

            FormUtilitarios_Load(null, null);
            conexao.Close();
            LimparCliente();
        }

        private void LimparCliente()
        {
            txtUser.Clear();
            txtSenha.Clear();
            cbxStatusCadastro.SelectedIndex = -1;
            rbnAdministrador.Checked = false;
            rbnAluno.Checked = false;
            rbnProfessor.Checked = false;
            txtData.Clear();
        }
    }

    
}
