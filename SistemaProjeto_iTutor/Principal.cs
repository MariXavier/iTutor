using SistemaProjeto_iTutor.Cadastros;
using SistemaProjeto_iTutor.Classes;
using SistemaProjeto_iTutor.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProjeto_iTutor
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.ShowDialog();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void lbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            FormCadastroProfessor formProfessor = new FormCadastroProfessor();
            formProfessor.ShowDialog();
        }

        private void BtnGerenciarCadastros_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Autenticacao.levelPermissao.ToString());
            if (Autenticacao.levelPermissao == 0)
            {
                FormUtilitarios formUtilitarios = new FormUtilitarios();
                formUtilitarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário sem permissão", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
