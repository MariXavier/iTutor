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
                MessageBox.Show("aqui");
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
            
            txtData.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUser.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSenha.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            string status = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (status == "0") {
                status = "Ativo";

            }
            else
            {
                status = "Inativo";
            }
            txtStatus.Text = status;
            string permissao = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            
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
    }

    
}
