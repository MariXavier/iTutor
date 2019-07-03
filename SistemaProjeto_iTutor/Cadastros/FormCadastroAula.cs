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

		int pkAluno = Autenticacao.pkAlunoLogado;
		int pkProfessor = Autenticacao.pkProfessorLogado;
		

		private void FormCadastroAula_Load(object sender, EventArgs e)
		{

			if (Autenticacao.levelPermissao == 2) //aluno
			{


				try
				{
					

					string sql = "SELECT a.dataAula AS 'Data Aula', a.horaInicial, a.horaFinal, s.nome, p.nome, d.nome AS 'Disciplina', e.rua, a.telefone, a.statusAula AS 'Status', pg.formaPagamento FROM aula AS a, aluno AS s, professor AS p, disciplina AS d, endereco AS e, pagamento AS pg WHERE a.fkAluno =" + pkAluno + " AND a.fkProfessor = p.pkProfessor AND a.fkDisciplina = d.pkDisciplina AND a.fkEndereco = e.pkEndereco AND a.fkPagamento = pg.pkPagamento;";
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
					DataSet ds = new DataSet();
					conexao.Open();
					da.Fill(ds, "aula");
					conexao.Close();
					dgvAulasAgendadas.DataSource = ds;
					dgvAulasAgendadas.DataMember = "aula";


					for (int i = 1; i < dgvAulasAgendadas.Columns.Count; i++)
					{
						dgvAulasAgendadas.Columns[i].Visible = true;
					}
					dgvAulasAgendadas.Columns[1].Visible = false;
					dgvAulasAgendadas.Columns[2].Visible = false;
					dgvAulasAgendadas.Columns[3].Visible = false;
					dgvAulasAgendadas.Columns[4].Visible = false;
					dgvAulasAgendadas.Columns[6].Visible = false;
					dgvAulasAgendadas.Columns[7].Visible = false;
					dgvAulasAgendadas.Columns[9].Visible = false;
					cbAluno.SelectedValue = dgvAulasAgendadas.Columns[3].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (Autenticacao.levelPermissao == 1) //professor
			{

				try
				{
					string sql = "SELECT a.dataAula AS 'Data Aula', a.horaInicial, a.horaFinal, s.nome, p.nome, d.nome AS 'Disciplina', e.rua, a.telefone, a.statusAula AS 'Status', pg.formaPagamento FROM aula AS a, aluno AS s, professor AS p, disciplina AS d, endereco AS e, pagamento AS pg WHERE a.fkProfessor = " + pkProfessor + " AND a.fkAluno = s.pkAluno AND a.fkDisciplina = d.pkDisciplina AND a.fkEndereco = e.pkEndereco AND a.fkPagamento = pg.pkPagamento;";
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
					DataSet ds = new DataSet();
					conexao.Open();
					da.Fill(ds, "aula");
					conexao.Close();
					dgvAulasAgendadas.DataSource = ds;
					dgvAulasAgendadas.DataMember = "aula";


					for (int i = 1; i < dgvAulasAgendadas.Columns.Count; i++)
					{
						dgvAulasAgendadas.Columns[i].Visible = true;
					}
					dgvAulasAgendadas.Columns[1].Visible = false;
					dgvAulasAgendadas.Columns[2].Visible = false;
					dgvAulasAgendadas.Columns[3].Visible = false;
					dgvAulasAgendadas.Columns[4].Visible = false;
					dgvAulasAgendadas.Columns[6].Visible = false;
					dgvAulasAgendadas.Columns[7].Visible = false;
					dgvAulasAgendadas.Columns[9].Visible = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else //admin
			{
				try
				{
					string sql = "SELECT * FROM aula;";
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
					DataSet ds = new DataSet();
					conexao.Open();
					da.Fill(ds, "aula");
					conexao.Close();
					dgvAulasAgendadas.DataSource = ds;
					dgvAulasAgendadas.DataMember = "aula";


					for (int i = 1; i < dgvAulasAgendadas.Columns.Count; i++)
					{
						dgvAulasAgendadas.Columns[i].Visible = true;
					}
					dgvAulasAgendadas.Columns[0].Visible = false;
					dgvAulasAgendadas.Columns[2].Visible = false;
					dgvAulasAgendadas.Columns[3].Visible = false;
					dgvAulasAgendadas.Columns[4].Visible = false;
					dgvAulasAgendadas.Columns[5].Visible = false;
					dgvAulasAgendadas.Columns[6].Visible = false;
					dgvAulasAgendadas.Columns[8].Visible = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void DgvAulasAgendadas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				preencherTextBoxUsuario(e);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void preencherTextBoxUsuario(DataGridViewCellEventArgs e)
		{
			cbProfessor.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[4].Value.ToString();
			cbDisciplina.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells["Disciplina"].Value.ToString();
			txtTelefone.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[7].Value.ToString();
			comboEndereco.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[6].Value.ToString();
			dateDataAula.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells["Data Aula"].Value.ToString();
			dateHoraInicial.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[1].Value.ToString();
			dateHoraFinal.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[2].Value.ToString();
			cbPagamento.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells[9].Value.ToString();
			cbStatusAula.Text = dgvAulasAgendadas.Rows[e.RowIndex].Cells["Status"].Value.ToString();

		}

		private void BtnAgendar_Click(object sender, EventArgs e)
		{
			if (Autenticacao.levelPermissao == 2)
			{

				try
				{
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlCommand query = new SqlCommand();

					query.Connection = conexao;
					conexao.Open();

					query.Parameters.AddWithValue("@aluno", cbAluno.SelectedValue);
					query.Parameters.AddWithValue("@professor", cbProfessor.SelectedValue);
					query.Parameters.AddWithValue("@disciplina", cbDisciplina.SelectedValue);
					query.Parameters.AddWithValue("@telefone", txtTelefone.Text);
					query.Parameters.AddWithValue("@endereco", comboEndereco.SelectedValue);
					query.Parameters.AddWithValue("@dataAula", dateDataAula.Text);
					query.Parameters.AddWithValue("@horaInicial", dateHoraInicial.Text);
					query.Parameters.AddWithValue("@horaFinal", dateHoraFinal.Text);
					query.Parameters.AddWithValue("@pagamento", cbPagamento.SelectedValue);
					query.Parameters.AddWithValue("@statusAula", cbStatusAula.SelectedValue);
					query.Parameters.AddWithValue("@conteudo", txtConteudo.Text);
					query.Parameters.AddWithValue("@observacao", txtObservacao.Text);


					query.CommandText = "INSERT INTO aula (dataAula, horaInicial, horaFinal, fkAluno, fkProfessor, fkDisciplina, fkEndereco, telefone, statusAula, fkPagamento, conteudo, observacao) values (@dataAula, @horaInicial, @horaFinal, @aluno, @professor, @disciplina, @endereco, @telefone, @statusAula, @pagamento, @conteudo, @observacao)";
					int cont = query.ExecuteNonQuery();

					if (cont > 0) { MessageBox.Show("Cadastro Realizado com Sucesso"); }
					else
					{
						MessageBox.Show("Erro ao Cadastrar");

					}
				}


				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (Autenticacao.levelPermissao == 1) //professor
			{

				try
				{
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlCommand query = new SqlCommand();

					query.Connection = conexao;
					conexao.Open();

					query.Parameters.AddWithValue("@aluno", cbAluno.SelectedValue);
					query.Parameters.AddWithValue("@professor", cbProfessor.SelectedValue);
					query.Parameters.AddWithValue("@disciplina", cbDisciplina.SelectedValue);
					query.Parameters.AddWithValue("@telefone", txtTelefone.Text);
					query.Parameters.AddWithValue("@endereco", comboEndereco.SelectedValue);
					query.Parameters.AddWithValue("@dataAula", dateDataAula.Text);
					query.Parameters.AddWithValue("@horaInicial", dateHoraInicial.Text);
					query.Parameters.AddWithValue("@horaFinal", dateHoraFinal.Text);
					query.Parameters.AddWithValue("@pagamento", cbPagamento.SelectedValue);
					query.Parameters.AddWithValue("@statusAula", cbStatusAula.SelectedValue);
					query.Parameters.AddWithValue("@conteudo", txtConteudo.Text);
					query.Parameters.AddWithValue("@observacao", txtObservacao.Text);


					query.CommandText = "INSERT INTO aula (dataAula, horaInicial, horaFinal, fkAluno, fkProfessor, fkDisciplina, fkEndereco, telefone, statusAula, fkPagamento, conteudo, observacao) values (@dataAula, @horaInicial, @horaFinal, @aluno, @lprofessor, @disciplina, @endereco, @telefone, @statusAula, @pagamento, @conteudo, @observacao)";
					int cont = query.ExecuteNonQuery();

					if (cont > 0) { MessageBox.Show("Cadastro Realizado com Sucesso"); }
					else
					{
						MessageBox.Show("Erro ao Cadastrar");

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
					SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
					SqlCommand query = new SqlCommand();

					query.Connection = conexao;
					conexao.Open();

					query.Parameters.AddWithValue("@aluno", cbAluno.SelectedValue);
					query.Parameters.AddWithValue("@professor", cbProfessor.SelectedValue);
					query.Parameters.AddWithValue("@disciplina", cbDisciplina.SelectedValue);
					query.Parameters.AddWithValue("@telefone", txtTelefone.Text);
					query.Parameters.AddWithValue("@endereco", comboEndereco.SelectedValue);
					query.Parameters.AddWithValue("@dataAula", dateDataAula.Text);
					query.Parameters.AddWithValue("@horaInicial", dateHoraInicial.Text);
					query.Parameters.AddWithValue("@horaFinal", dateHoraFinal.Text);
					query.Parameters.AddWithValue("@pagamento", cbPagamento.SelectedValue);
					query.Parameters.AddWithValue("@statusAula", cbStatusAula.SelectedValue);
					query.Parameters.AddWithValue("@conteudo", txtConteudo.Text);
					query.Parameters.AddWithValue("@observacao", txtObservacao.Text);


					query.CommandText = "INSERT INTO aula (dataAula, horaInicial, horaFinal, fkAluno, fkProfessor, fkDisciplina, fkEndereco, telefone, statusAula, fkPagamento, conteudo, observacao) values (@dataAula, @horaInicial, @horaFinal, @aluno, @lprofessor, @disciplina, @endereco, @telefone, @statusAula, @pagamento, @conteudo, @observacao)";
					int cont = query.ExecuteNonQuery();

					if (cont > 0) { MessageBox.Show("Cadastro Realizado com Sucesso"); }
					else
					{
						MessageBox.Show("Erro ao Cadastrar");

					}
				}


				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}

		public void Aluno(object sender, EventArgs e)
		{
			string sql = "SELECT nome FROM aluno WHERE pkAluno =" + pkAluno + " ;";
			SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
			SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
			DataSet ds = new DataSet();
			conexao.Open();
			da.Fill(ds, "comboAluno");
			cbAluno.DisplayMember = "comboAluno";
			cbAluno.DataSource = ds;
			conexao.Close();
		}

		public void Professor(object sender, EventArgs e)
		{
			string sql = "SELECT nome FROM professor WHERE pkProfessor =" + pkProfessor + " ;";
			SqlConnection conexao = new SqlConnection(Banco.enderecoBanco());
			SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
			DataSet ds = new DataSet();
			conexao.Open();
			da.Fill(ds, "comboProfessor");
			cbProfessor.DisplayMember = "comboProfessor";
			cbProfessor.DataSource = ds;
			conexao.Close();
		}

	}
}
