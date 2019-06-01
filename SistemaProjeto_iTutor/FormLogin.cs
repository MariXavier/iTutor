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

namespace SistemaProjeto_iTutor
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from usuario where usuario = @usuario and senha = @senha";
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            conexao.Open();
            
            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (!consulta.Read())
            {

                MessageBox.Show("Usuário ou senha inválido");
            }
            else
            {
                consulta.Close();
                conexao.Open();
                
                comando.CommandText = "SELECT levelPermissao FROM usuario WHERE usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                
                //string lvl = tabela.Rows[0]["levelPermissao"].ToString();
                //int levelPermissao = Convert.ToInt32(lvl);
                
                Autenticacao.levelPermissao = Convert.ToInt32(tabela.Rows[0]["levelPermissao"].ToString());
                
                //Autenticacao.levelPermissao = Convert.ToInt32(consulta.GetValue(3));

                Limpar.limparComponentes(this);
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
                
            }
            conexao.Close();

        }
    }
}
