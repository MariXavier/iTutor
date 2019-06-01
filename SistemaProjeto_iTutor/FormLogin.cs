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
                Limpar.limparComponentes(this);
                Autenticacao.levelPermissao = Convert.ToInt32(consulta.GetValue(3));
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }

            conexao.Close();
        }
    }
}
