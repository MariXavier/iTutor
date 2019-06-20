namespace SistemaProjeto_iTutor.Utilitarios
{
    partial class FormUtilitarios
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
			this.components = new System.ComponentModel.Container();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.pkUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.levelPermissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.solicitacaoAprovadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.statusCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.iTutorDataSet = new SistemaProjeto_iTutor.iTutorDataSet();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupPerfil = new System.Windows.Forms.GroupBox();
			this.rbnAdministrador = new System.Windows.Forms.RadioButton();
			this.rbnProfessor = new System.Windows.Forms.RadioButton();
			this.rbnAluno = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.usuarioTableAdapter = new SistemaProjeto_iTutor.iTutorDataSetTableAdapters.usuarioTableAdapter();
			this.txtData = new System.Windows.Forms.MaskedTextBox();
			this.cbxStatusCadastro = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iTutorDataSet)).BeginInit();
			this.groupPerfil.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AutoGenerateColumns = false;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkUsuario,
            this.usuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.levelPermissaoDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.solicitacaoAprovadaDataGridViewCheckBoxColumn,
            this.statusCadastroDataGridViewTextBoxColumn});
			this.dgvUsuarios.DataSource = this.usuarioBindingSource;
			this.dgvUsuarios.Location = new System.Drawing.Point(12, 69);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.RowTemplate.ReadOnly = true;
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(374, 285);
			this.dgvUsuarios.TabIndex = 0;
			this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
			// 
			// pkUsuario
			// 
			this.pkUsuario.DataPropertyName = "pkUsuario";
			this.pkUsuario.HeaderText = "pkUsuario";
			this.pkUsuario.Name = "pkUsuario";
			this.pkUsuario.ReadOnly = true;
			this.pkUsuario.Visible = false;
			// 
			// usuarioDataGridViewTextBoxColumn
			// 
			this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
			this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
			this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			// 
			// levelPermissaoDataGridViewTextBoxColumn
			// 
			this.levelPermissaoDataGridViewTextBoxColumn.DataPropertyName = "levelPermissao";
			this.levelPermissaoDataGridViewTextBoxColumn.HeaderText = "levelPermissao";
			this.levelPermissaoDataGridViewTextBoxColumn.Name = "levelPermissaoDataGridViewTextBoxColumn";
			this.levelPermissaoDataGridViewTextBoxColumn.Visible = false;
			// 
			// dataCriacaoDataGridViewTextBoxColumn
			// 
			this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "dataCriacao";
			this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "Data de Criação";
			this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
			this.dataCriacaoDataGridViewTextBoxColumn.Width = 130;
			// 
			// solicitacaoAprovadaDataGridViewCheckBoxColumn
			// 
			this.solicitacaoAprovadaDataGridViewCheckBoxColumn.DataPropertyName = "solicitacaoAprovada";
			this.solicitacaoAprovadaDataGridViewCheckBoxColumn.HeaderText = "solicitacaoAprovada";
			this.solicitacaoAprovadaDataGridViewCheckBoxColumn.Name = "solicitacaoAprovadaDataGridViewCheckBoxColumn";
			this.solicitacaoAprovadaDataGridViewCheckBoxColumn.Visible = false;
			// 
			// statusCadastroDataGridViewTextBoxColumn
			// 
			this.statusCadastroDataGridViewTextBoxColumn.DataPropertyName = "statusCadastro";
			this.statusCadastroDataGridViewTextBoxColumn.HeaderText = "statusCadastro";
			this.statusCadastroDataGridViewTextBoxColumn.Name = "statusCadastroDataGridViewTextBoxColumn";
			this.statusCadastroDataGridViewTextBoxColumn.Visible = false;
			// 
			// usuarioBindingSource
			// 
			this.usuarioBindingSource.DataMember = "usuario";
			this.usuarioBindingSource.DataSource = this.iTutorDataSet;
			// 
			// iTutorDataSet
			// 
			this.iTutorDataSet.DataSetName = "iTutorDataSet";
			this.iTutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(547, 134);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 16);
			this.label13.TabIndex = 170;
			this.label13.Text = "Status Cadastro";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(573, 73);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 16);
			this.label14.TabIndex = 171;
			this.label14.Text = "Senha";
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(576, 90);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(120, 22);
			this.txtSenha.TabIndex = 154;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = global::SistemaProjeto_iTutor.Properties.Resources.save;
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(433, 320);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(101, 34);
			this.btnSalvar.TabIndex = 155;
			this.btnSalvar.Text = "Cadastrar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Image = global::SistemaProjeto_iTutor.Properties.Resources.edit_2_;
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(540, 320);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(78, 34);
			this.btnAlterar.TabIndex = 156;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Image = global::SistemaProjeto_iTutor.Properties.Resources.eraser;
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.Location = new System.Drawing.Point(624, 320);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(78, 34);
			this.btnLimpar.TabIndex = 157;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(396, 134);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 16);
			this.label8.TabIndex = 165;
			this.label8.Text = "Data Criação";
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(395, 91);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(164, 22);
			this.txtUser.TabIndex = 142;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(392, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 16);
			this.label1.TabIndex = 159;
			this.label1.Text = "Usuário";
			// 
			// groupPerfil
			// 
			this.groupPerfil.Controls.Add(this.rbnAdministrador);
			this.groupPerfil.Controls.Add(this.rbnProfessor);
			this.groupPerfil.Controls.Add(this.rbnAluno);
			this.groupPerfil.Location = new System.Drawing.Point(396, 204);
			this.groupPerfil.Name = "groupPerfil";
			this.groupPerfil.Size = new System.Drawing.Size(301, 48);
			this.groupPerfil.TabIndex = 175;
			this.groupPerfil.TabStop = false;
			this.groupPerfil.Text = "Perfil Usuário";
			// 
			// rbnAdministrador
			// 
			this.rbnAdministrador.AutoSize = true;
			this.rbnAdministrador.Location = new System.Drawing.Point(198, 20);
			this.rbnAdministrador.Name = "rbnAdministrador";
			this.rbnAdministrador.Size = new System.Drawing.Size(88, 17);
			this.rbnAdministrador.TabIndex = 2;
			this.rbnAdministrador.TabStop = true;
			this.rbnAdministrador.Text = "Administrador";
			this.rbnAdministrador.UseVisualStyleBackColor = true;
			// 
			// rbnProfessor
			// 
			this.rbnProfessor.AutoSize = true;
			this.rbnProfessor.Location = new System.Drawing.Point(104, 19);
			this.rbnProfessor.Name = "rbnProfessor";
			this.rbnProfessor.Size = new System.Drawing.Size(69, 17);
			this.rbnProfessor.TabIndex = 1;
			this.rbnProfessor.TabStop = true;
			this.rbnProfessor.Text = "Professor";
			this.rbnProfessor.UseVisualStyleBackColor = true;
			// 
			// rbnAluno
			// 
			this.rbnAluno.AutoSize = true;
			this.rbnAluno.Location = new System.Drawing.Point(20, 20);
			this.rbnAluno.Name = "rbnAluno";
			this.rbnAluno.Size = new System.Drawing.Size(52, 17);
			this.rbnAluno.TabIndex = 0;
			this.rbnAluno.TabStop = true;
			this.rbnAluno.Text = "Aluno";
			this.rbnAluno.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(-1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(796, 52);
			this.panel2.TabIndex = 176;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::SistemaProjeto_iTutor.Properties.Resources.iconfinder_user_group_new_23632;
			this.pictureBox2.Location = new System.Drawing.Point(4, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(63, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(239, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "Gerenciamento de Perfis";
			// 
			// usuarioTableAdapter
			// 
			this.usuarioTableAdapter.ClearBeforeFill = true;
			// 
			// txtData
			// 
			this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtData.Location = new System.Drawing.Point(396, 153);
			this.txtData.Mask = "00/00/0000";
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = true;
			this.txtData.Size = new System.Drawing.Size(137, 22);
			this.txtData.TabIndex = 177;
			this.txtData.ValidatingType = typeof(System.DateTime);
			// 
			// cbxStatusCadastro
			// 
			this.cbxStatusCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxStatusCadastro.FormattingEnabled = true;
			this.cbxStatusCadastro.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
			this.cbxStatusCadastro.Location = new System.Drawing.Point(550, 153);
			this.cbxStatusCadastro.Name = "cbxStatusCadastro";
			this.cbxStatusCadastro.Size = new System.Drawing.Size(147, 24);
			this.cbxStatusCadastro.TabIndex = 178;
			// 
			// FormUtilitarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 366);
			this.ControlBox = false;
			this.Controls.Add(this.cbxStatusCadastro);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupPerfil);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvUsuarios);
			this.Name = "FormUtilitarios";
			this.Text = "Utilitários";
			this.Load += new System.EventHandler(this.FormUtilitarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iTutorDataSet)).EndInit();
			this.groupPerfil.ResumeLayout(false);
			this.groupPerfil.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPerfil;
        private System.Windows.Forms.RadioButton rbnAdministrador;
        private System.Windows.Forms.RadioButton rbnProfessor;
        private System.Windows.Forms.RadioButton rbnAluno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private iTutorDataSet iTutorDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private iTutorDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelPermissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solicitacaoAprovadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxStatusCadastro;
    }
}