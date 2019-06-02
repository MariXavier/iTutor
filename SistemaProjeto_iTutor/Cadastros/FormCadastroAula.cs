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
    public partial class FormCadastroAula : Form
    {
        public FormCadastroAula()
        {
            InitializeComponent();
        }

        private void FormCadastroAula_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Banco.enderecoBanco());
            conn.Open();
            SqlCommand sc = new SqlCommand("select nome from disciplina", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("nome");
            dt.Load(reader);

            cbDisciplina.ValueMember = "codigo";
            cbDisciplina.DisplayMember = "nome";
            cbDisciplina.DataSource = dt;

            conn.Close();
        }

        private void comboStatusAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNovoEndereco_Click(object sender, EventArgs e)
        {
            FormCadastroEndereco formEndereco = new FormCadastroEndereco();
            formEndereco.ShowDialog();
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDisciplina_Click(object sender, EventArgs e)
        {
            
        }
    }
}
