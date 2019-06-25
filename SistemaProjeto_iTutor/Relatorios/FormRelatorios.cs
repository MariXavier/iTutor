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
using SistemaProjeto_iTutor.Classes;


namespace SistemaProjeto_iTutor.Relatorios
{
	public partial class FormRelatorios : Form
	{
		public FormRelatorios()
		{
			InitializeComponent();
		}

		int pkAluno = Autenticacao.pkAlunoLogado;

		private void FormRelatorios_Load(object sender, EventArgs e)
		{
			if (Autenticacao.levelPermissao == 2) //aluno
			{
				rbnProfessores.Visible = false;
				rbnFinanceiro.Visible = false;
				rbnAlunos.Visible = false;

				//btnAlterar.Location = new Point(679, 363);
				
			}

		}

		private void BtnGerarCubo_Click(object sender, EventArgs e)
		{

			if (rbnAulas.Checked == true)
			{
				string dataInicial, dataFinal;

				dataInicial = maskDataInicial.Mask;
				dataFinal = maskDataFinal.Mask;

				try
				{
					string sql = "SELECT a.pkAluno, a.dataAula AS 'Data Aula', a.fkProfessor AS 'Professor', a.fkDisciplina AS 'Disciplina', a.fkEndereco AS 'Endereço', a.statusAula AS 'Status Aula', a.fkPagamento AS 'Pagamento', u.statusCadastro FROM aula AS a, usuario AS u WHERE pkAluno = " + pkAluno + " AND u.fkAluno = " + pkAluno + " AND u.statusCadastro = 0 AND a.dataAula BETWEEN dataInicial AND dataFinal;";
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
					DataSet ds = new DataSet();
					conexao.Open();
					da.Fill(ds, "aluno");
					conexao.Close();
					dgvCubo.DataSource = ds;
					dgvCubo.DataMember = "aluno";

					for (int i = 1; i < dgvCubo.Columns.Count; i++)
					{
						dgvCubo.Columns[0].Visible = false;
						dgvCubo.Columns[i].Visible = true;
					}
					dgvCubo.Columns[5].Visible = false;
					dgvCubo.Columns[3].Visible = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
