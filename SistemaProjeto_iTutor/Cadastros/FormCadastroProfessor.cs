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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroProfessor_Load(object sender, EventArgs e)
        {
            MessageBox.Show(pkProfessor.ToString());
            if(Autenticacao.levelPermissao == 1) //professor
            {
                btnExcluir.Visible = false;
                btnLimpar.Visible = false;
                btnSalvar.Visible = false;

                //SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
                //string sql = "SELECT p.nome, p.cpf, d.nome, p.dataNascimento, p.email, p.telefone, e.cep, e.rua, e.numero, e.bairro, e.cidade, e.estado, u.usuario, u.senha FROM professor AS p, disciplina AS d, endereco AS e, usuario AS u";
                //SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            }
            else //admin
            {

            }
        }
    }
}
