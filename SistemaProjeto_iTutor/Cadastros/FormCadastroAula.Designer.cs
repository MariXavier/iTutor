namespace SistemaProjeto_iTutor.Cadastros
{
    partial class FormCadastroAula
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAula));
			this.comboEndereço = new System.Windows.Forms.ComboBox();
			this.lblValorTotal = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboStatusAula = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboPagamento = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtConteudo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbDisciplina = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbProfessor = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbAluno = new System.Windows.Forms.ComboBox();
			this.lbNovoEndereco = new System.Windows.Forms.Label();
			this.btnAgendar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvAulasAgendadas = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAulasAgendadas)).BeginInit();
			this.SuspendLayout();
			// 
			// comboEndereço
			// 
			this.comboEndereço.FormattingEnabled = true;
			this.comboEndereço.Location = new System.Drawing.Point(445, 76);
			this.comboEndereço.Name = "comboEndereço";
			this.comboEndereço.Size = new System.Drawing.Size(271, 21);
			this.comboEndereço.TabIndex = 69;
			// 
			// lblValorTotal
			// 
			this.lblValorTotal.AutoSize = true;
			this.lblValorTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorTotal.Location = new System.Drawing.Point(309, 360);
			this.lblValorTotal.Name = "lblValorTotal";
			this.lblValorTotal.Size = new System.Drawing.Size(20, 16);
			this.lblValorTotal.TabIndex = 67;
			this.lblValorTotal.Text = "---";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(309, 339);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(102, 16);
			this.label14.TabIndex = 66;
			this.label14.Text = "VALOR TOTAL: ";
			// 
			// txtObservacao
			// 
			this.txtObservacao.Location = new System.Drawing.Point(535, 228);
			this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(216, 107);
			this.txtObservacao.TabIndex = 64;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(532, 208);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(76, 16);
			this.label13.TabIndex = 63;
			this.label13.Text = "Observação";
			// 
			// comboStatusAula
			// 
			this.comboStatusAula.FormattingEnabled = true;
			this.comboStatusAula.Location = new System.Drawing.Point(566, 179);
			this.comboStatusAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboStatusAula.Name = "comboStatusAula";
			this.comboStatusAula.Size = new System.Drawing.Size(184, 21);
			this.comboStatusAula.TabIndex = 62;
			this.comboStatusAula.SelectedIndexChanged += new System.EventHandler(this.comboStatusAula_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(563, 159);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 16);
			this.label12.TabIndex = 61;
			this.label12.Text = "Status da Aula";
			// 
			// comboPagamento
			// 
			this.comboPagamento.FormattingEnabled = true;
			this.comboPagamento.Location = new System.Drawing.Point(312, 179);
			this.comboPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboPagamento.Name = "comboPagamento";
			this.comboPagamento.Size = new System.Drawing.Size(248, 21);
			this.comboPagamento.TabIndex = 60;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(309, 159);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 16);
			this.label11.TabIndex = 59;
			this.label11.Text = "Forma de Pagamento";
			// 
			// txtConteudo
			// 
			this.txtConteudo.Location = new System.Drawing.Point(312, 228);
			this.txtConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtConteudo.Multiline = true;
			this.txtConteudo.Name = "txtConteudo";
			this.txtConteudo.Size = new System.Drawing.Size(214, 107);
			this.txtConteudo.TabIndex = 58;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(309, 208);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 16);
			this.label10.TabIndex = 57;
			this.label10.Text = "Conteúdo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(309, 102);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 16);
			this.label9.TabIndex = 56;
			this.label9.Text = "Telefone";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(436, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 16);
			this.label8.TabIndex = 55;
			this.label8.Text = "Endereço";
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(312, 122);
			this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(127, 26);
			this.txtTelefone.TabIndex = 54;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.CustomFormat = "HH:mm";
			this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(669, 123);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowUpDown = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(81, 26);
			this.dateTimePicker2.TabIndex = 53;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(666, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 16);
			this.label6.TabIndex = 52;
			this.label6.Text = "Horário final";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(572, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 16);
			this.label7.TabIndex = 51;
			this.label7.Text = "Horário inicial";
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Checked = false;
			this.dateTimePicker3.CustomFormat = "HH:mm";
			this.dateTimePicker3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker3.Location = new System.Drawing.Point(575, 123);
			this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.ShowUpDown = true;
			this.dateTimePicker3.Size = new System.Drawing.Size(88, 26);
			this.dateTimePicker3.TabIndex = 50;
			this.dateTimePicker3.Value = new System.DateTime(2019, 5, 4, 15, 50, 0, 0);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(442, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 16);
			this.label5.TabIndex = 49;
			this.label5.Text = "Data da Aula";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(445, 123);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(124, 26);
			this.dateTimePicker1.TabIndex = 48;
			// 
			// cbDisciplina
			// 
			this.cbDisciplina.FormattingEnabled = true;
			this.cbDisciplina.Location = new System.Drawing.Point(312, 77);
			this.cbDisciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbDisciplina.Name = "cbDisciplina";
			this.cbDisciplina.Size = new System.Drawing.Size(127, 21);
			this.cbDisciplina.TabIndex = 47;
			this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
			this.cbDisciplina.Click += new System.EventHandler(this.cbDisciplina_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(309, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 46;
			this.label4.Text = "Disciplina";
			// 
			// cbProfessor
			// 
			this.cbProfessor.FormattingEnabled = true;
			this.cbProfessor.Location = new System.Drawing.Point(521, 28);
			this.cbProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbProfessor.Name = "cbProfessor";
			this.cbProfessor.Size = new System.Drawing.Size(230, 21);
			this.cbProfessor.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(519, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 44;
			this.label2.Text = "Professor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(309, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 16);
			this.label3.TabIndex = 42;
			this.label3.Text = "Aluno";
			// 
			// cbAluno
			// 
			this.cbAluno.FormattingEnabled = true;
			this.cbAluno.Location = new System.Drawing.Point(312, 28);
			this.cbAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbAluno.Name = "cbAluno";
			this.cbAluno.Size = new System.Drawing.Size(203, 21);
			this.cbAluno.TabIndex = 97;
			// 
			// lbNovoEndereco
			// 
			this.lbNovoEndereco.AutoSize = true;
			this.lbNovoEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNovoEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbNovoEndereco.Location = new System.Drawing.Point(717, 77);
			this.lbNovoEndereco.Name = "lbNovoEndereco";
			this.lbNovoEndereco.Size = new System.Drawing.Size(36, 16);
			this.lbNovoEndereco.TabIndex = 98;
			this.lbNovoEndereco.Text = "Novo";
			this.lbNovoEndereco.Click += new System.EventHandler(this.lbNovoEndereco_Click);
			// 
			// btnAgendar
			// 
			this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(108)))));
			this.btnAgendar.FlatAppearance.BorderSize = 0;
			this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgendar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgendar.Location = new System.Drawing.Point(437, 342);
			this.btnAgendar.Name = "btnAgendar";
			this.btnAgendar.Size = new System.Drawing.Size(78, 34);
			this.btnAgendar.TabIndex = 99;
			this.btnAgendar.Text = "Agendar";
			this.btnAgendar.UseVisualStyleBackColor = false;
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnAlterar.FlatAppearance.BorderSize = 0;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(522, 342);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(78, 34);
			this.btnAlterar.TabIndex = 100;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(194)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.Location = new System.Drawing.Point(606, 342);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(78, 34);
			this.btnLimpar.TabIndex = 101;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(689, 342);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(61, 34);
			this.btnExcluir.TabIndex = 102;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvAulasAgendadas);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(293, 369);
			this.groupBox1.TabIndex = 103;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Aulas Agendadas";
			// 
			// dgvAulasAgendadas
			// 
			this.dgvAulasAgendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAulasAgendadas.Location = new System.Drawing.Point(7, 22);
			this.dgvAulasAgendadas.Name = "dgvAulasAgendadas";
			this.dgvAulasAgendadas.Size = new System.Drawing.Size(280, 341);
			this.dgvAulasAgendadas.TabIndex = 0;
			// 
			// FormCadastroAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 388);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnAgendar);
			this.Controls.Add(this.lbNovoEndereco);
			this.Controls.Add(this.cbAluno);
			this.Controls.Add(this.comboEndereço);
			this.Controls.Add(this.lblValorTotal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.comboStatusAula);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.comboPagamento);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtConteudo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePicker3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cbDisciplina);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbProfessor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastroAula";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agendamento de Aulas";
			this.Load += new System.EventHandler(this.FormCadastroAula_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAulasAgendadas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEndereço;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboStatusAula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.Label lbNovoEndereco;
		private System.Windows.Forms.Button btnAgendar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvAulasAgendadas;
	}
}