namespace SistemaProjeto_iTutor.Relatorios
{
	partial class FormRelatorios
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabCubo = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.dgvCubo = new System.Windows.Forms.DataGridView();
			this.tabFiltro = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.maskDataFinal = new System.Windows.Forms.MaskedTextBox();
			this.maskDataInicial = new System.Windows.Forms.MaskedTextBox();
			this.btnGerarCubo = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.rbnAulas = new System.Windows.Forms.RadioButton();
			this.rbnAlunos = new System.Windows.Forms.RadioButton();
			this.rbnProfessores = new System.Windows.Forms.RadioButton();
			this.rbnFinanceiro = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.tabCubo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCubo)).BeginInit();
			this.tabFiltro.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbnFinanceiro);
			this.groupBox1.Controls.Add(this.rbnProfessores);
			this.groupBox1.Controls.Add(this.rbnAlunos);
			this.groupBox1.Controls.Add(this.rbnAulas);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 387);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Consulta";
			// 
			// tabCubo
			// 
			this.tabCubo.Controls.Add(this.button1);
			this.tabCubo.Controls.Add(this.btnAlterar);
			this.tabCubo.Controls.Add(this.button2);
			this.tabCubo.Controls.Add(this.btnExcluir);
			this.tabCubo.Controls.Add(this.dgvCubo);
			this.tabCubo.Location = new System.Drawing.Point(4, 22);
			this.tabCubo.Name = "tabCubo";
			this.tabCubo.Padding = new System.Windows.Forms.Padding(3);
			this.tabCubo.Size = new System.Drawing.Size(475, 361);
			this.tabCubo.TabIndex = 1;
			this.tabCubo.Text = "Cubo";
			this.tabCubo.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(108)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(137, 316);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 34);
			this.button1.TabIndex = 17;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnAlterar.FlatAppearance.BorderSize = 0;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(221, 316);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(78, 34);
			this.btnAlterar.TabIndex = 18;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(194)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(305, 316);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 34);
			this.button2.TabIndex = 19;
			this.button2.Text = "Limpar";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(389, 316);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(78, 34);
			this.btnExcluir.TabIndex = 20;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// dgvCubo
			// 
			this.dgvCubo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCubo.Location = new System.Drawing.Point(6, 19);
			this.dgvCubo.Name = "dgvCubo";
			this.dgvCubo.Size = new System.Drawing.Size(463, 271);
			this.dgvCubo.TabIndex = 1;
			// 
			// tabFiltro
			// 
			this.tabFiltro.Controls.Add(this.label2);
			this.tabFiltro.Controls.Add(this.label1);
			this.tabFiltro.Controls.Add(this.maskDataFinal);
			this.tabFiltro.Controls.Add(this.maskDataInicial);
			this.tabFiltro.Controls.Add(this.btnGerarCubo);
			this.tabFiltro.Controls.Add(this.btnLimpar);
			this.tabFiltro.Location = new System.Drawing.Point(4, 22);
			this.tabFiltro.Name = "tabFiltro";
			this.tabFiltro.Padding = new System.Windows.Forms.Padding(3);
			this.tabFiltro.Size = new System.Drawing.Size(475, 361);
			this.tabFiltro.TabIndex = 0;
			this.tabFiltro.Text = "Filtros";
			this.tabFiltro.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "Data Final de Consulta";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Data Inicial de Consulta";
			// 
			// maskDataFinal
			// 
			this.maskDataFinal.Location = new System.Drawing.Point(131, 50);
			this.maskDataFinal.Mask = "00/00/0000";
			this.maskDataFinal.Name = "maskDataFinal";
			this.maskDataFinal.Size = new System.Drawing.Size(114, 20);
			this.maskDataFinal.TabIndex = 28;
			this.maskDataFinal.ValidatingType = typeof(System.DateTime);
			// 
			// maskDataInicial
			// 
			this.maskDataInicial.Location = new System.Drawing.Point(131, 19);
			this.maskDataInicial.Mask = "00/00/0000";
			this.maskDataInicial.Name = "maskDataInicial";
			this.maskDataInicial.Size = new System.Drawing.Size(114, 20);
			this.maskDataInicial.TabIndex = 27;
			this.maskDataInicial.ValidatingType = typeof(System.DateTime);
			// 
			// btnGerarCubo
			// 
			this.btnGerarCubo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(108)))));
			this.btnGerarCubo.FlatAppearance.BorderSize = 0;
			this.btnGerarCubo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGerarCubo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGerarCubo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnGerarCubo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGerarCubo.Location = new System.Drawing.Point(9, 112);
			this.btnGerarCubo.Name = "btnGerarCubo";
			this.btnGerarCubo.Size = new System.Drawing.Size(100, 34);
			this.btnGerarCubo.TabIndex = 25;
			this.btnGerarCubo.Text = "Gerar Cubo";
			this.btnGerarCubo.UseVisualStyleBackColor = false;
			this.btnGerarCubo.Click += new System.EventHandler(this.BtnGerarCubo_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(194)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.Location = new System.Drawing.Point(131, 112);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(100, 34);
			this.btnLimpar.TabIndex = 26;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabFiltro);
			this.tabControl1.Controls.Add(this.tabCubo);
			this.tabControl1.Location = new System.Drawing.Point(271, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(483, 387);
			this.tabControl1.TabIndex = 2;
			// 
			// rbnAulas
			// 
			this.rbnAulas.AutoSize = true;
			this.rbnAulas.Location = new System.Drawing.Point(7, 36);
			this.rbnAulas.Name = "rbnAulas";
			this.rbnAulas.Size = new System.Drawing.Size(142, 21);
			this.rbnAulas.TabIndex = 0;
			this.rbnAulas.TabStop = true;
			this.rbnAulas.Text = "Relatório de Aulas";
			this.rbnAulas.UseVisualStyleBackColor = true;
			// 
			// rbnAlunos
			// 
			this.rbnAlunos.AutoSize = true;
			this.rbnAlunos.Location = new System.Drawing.Point(6, 63);
			this.rbnAlunos.Name = "rbnAlunos";
			this.rbnAlunos.Size = new System.Drawing.Size(153, 21);
			this.rbnAlunos.TabIndex = 1;
			this.rbnAlunos.TabStop = true;
			this.rbnAlunos.Text = "Alunos Cadastrados";
			this.rbnAlunos.UseVisualStyleBackColor = true;
			// 
			// rbnProfessores
			// 
			this.rbnProfessores.AutoSize = true;
			this.rbnProfessores.Location = new System.Drawing.Point(7, 90);
			this.rbnProfessores.Name = "rbnProfessores";
			this.rbnProfessores.Size = new System.Drawing.Size(186, 21);
			this.rbnProfessores.TabIndex = 2;
			this.rbnProfessores.TabStop = true;
			this.rbnProfessores.Text = "Professores Cadastrados";
			this.rbnProfessores.UseVisualStyleBackColor = true;
			// 
			// rbnFinanceiro
			// 
			this.rbnFinanceiro.AutoSize = true;
			this.rbnFinanceiro.Location = new System.Drawing.Point(7, 117);
			this.rbnFinanceiro.Name = "rbnFinanceiro";
			this.rbnFinanceiro.Size = new System.Drawing.Size(92, 21);
			this.rbnFinanceiro.TabIndex = 3;
			this.rbnFinanceiro.TabStop = true;
			this.rbnFinanceiro.Text = "Financeiro";
			this.rbnFinanceiro.UseVisualStyleBackColor = true;
			// 
			// FormRelatorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 427);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormRelatorios";
			this.Text = "Relatórios";
			this.Load += new System.EventHandler(this.FormRelatorios_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabCubo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCubo)).EndInit();
			this.tabFiltro.ResumeLayout(false);
			this.tabFiltro.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tabCubo;
		private System.Windows.Forms.TabPage tabFiltro;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskDataFinal;
		private System.Windows.Forms.MaskedTextBox maskDataInicial;
		private System.Windows.Forms.Button btnGerarCubo;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.DataGridView dgvCubo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.RadioButton rbnFinanceiro;
		private System.Windows.Forms.RadioButton rbnProfessores;
		private System.Windows.Forms.RadioButton rbnAlunos;
		private System.Windows.Forms.RadioButton rbnAulas;
	}
}