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
	public partial class FormMenu : Form
	{
		public FormMenu()
		{
			InitializeComponent();
		}

		private void FormMenu_Load(object sender, EventArgs e)
		{
			FormLogin flogin = new FormLogin(); /*aparecerá a tela de login e só mostra a principal quando sair desta*/
			flogin.ShowDialog();
		}
	
	}
	
}
