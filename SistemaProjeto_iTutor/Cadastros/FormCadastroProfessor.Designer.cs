﻿namespace SistemaProjeto_iTutor.Cadastros
{
    partial class FormCadastroProfessor
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboFormacaoProfessor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProfressor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPFProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtNumProfessor = new System.Windows.Forms.TextBox();
            this.txtCEPProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNascimentoProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairroProfessor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidadeProfessor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstadoProfessor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmailProfessor = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorHoraAula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::SistemaProjeto_iTutor.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(375, 390);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 34);
            this.btnSalvar.TabIndex = 94;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::SistemaProjeto_iTutor.Properties.Resources.edit_2_;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(459, 390);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(78, 34);
            this.btnAlterar.TabIndex = 93;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::SistemaProjeto_iTutor.Properties.Resources.eraser;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(543, 390);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(78, 34);
            this.btnLimpar.TabIndex = 92;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::SistemaProjeto_iTutor.Properties.Resources.delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(627, 390);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 34);
            this.btnExcluir.TabIndex = 91;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.AllowUserToAddRows = false;
            this.dgvProfessor.AllowUserToDeleteRows = false;
            this.dgvProfessor.AllowUserToResizeRows = false;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Location = new System.Drawing.Point(15, 71);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.Size = new System.Drawing.Size(299, 353);
            this.dgvProfessor.TabIndex = 62;
            this.dgvProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessor_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 52);
            this.panel2.TabIndex = 61;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaProjeto_iTutor.Properties.Resources.clipboard;
            this.pictureBox2.Location = new System.Drawing.Point(15, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Professores";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(455, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Formação acadêmica";
            // 
            // comboFormacaoProfessor
            // 
            this.comboFormacaoProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormacaoProfessor.FormattingEnabled = true;
            this.comboFormacaoProfessor.Location = new System.Drawing.Point(458, 282);
            this.comboFormacaoProfessor.Name = "comboFormacaoProfessor";
            this.comboFormacaoProfessor.Size = new System.Drawing.Size(149, 24);
            this.comboFormacaoProfessor.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nome";
            // 
            // txtNomeProfressor
            // 
            this.txtNomeProfressor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfressor.Location = new System.Drawing.Point(334, 88);
            this.txtNomeProfressor.Name = "txtNomeProfressor";
            this.txtNomeProfressor.Size = new System.Drawing.Size(271, 22);
            this.txtNomeProfressor.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(415, 130);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(190, 22);
            this.txtRua.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "Nº";
            // 
            // txtCPFProfessor
            // 
            this.txtCPFProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFProfessor.Location = new System.Drawing.Point(333, 230);
            this.txtCPFProfessor.Mask = "000.000.000-00";
            this.txtCPFProfessor.Name = "txtCPFProfessor";
            this.txtCPFProfessor.Size = new System.Drawing.Size(108, 22);
            this.txtCPFProfessor.TabIndex = 116;
            // 
            // txtNumProfessor
            // 
            this.txtNumProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumProfessor.Location = new System.Drawing.Point(618, 130);
            this.txtNumProfessor.Name = "txtNumProfessor";
            this.txtNumProfessor.Size = new System.Drawing.Size(87, 22);
            this.txtNumProfessor.TabIndex = 102;
            // 
            // txtCEPProfessor
            // 
            this.txtCEPProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEPProfessor.Location = new System.Drawing.Point(334, 130);
            this.txtCEPProfessor.Mask = "00000-000";
            this.txtCEPProfessor.Name = "txtCEPProfessor";
            this.txtCEPProfessor.Size = new System.Drawing.Size(76, 22);
            this.txtCEPProfessor.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "Bairro";
            // 
            // txtNascimentoProfessor
            // 
            this.txtNascimentoProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimentoProfessor.Location = new System.Drawing.Point(618, 88);
            this.txtNascimentoProfessor.Mask = "00/00/0000";
            this.txtNascimentoProfessor.Name = "txtNascimentoProfessor";
            this.txtNascimentoProfessor.Size = new System.Drawing.Size(87, 22);
            this.txtNascimentoProfessor.TabIndex = 114;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 112;
            this.label12.Text = "Telefone";
            // 
            // txtBairroProfessor
            // 
            this.txtBairroProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroProfessor.Location = new System.Drawing.Point(333, 180);
            this.txtBairroProfessor.Name = "txtBairroProfessor";
            this.txtBairroProfessor.Size = new System.Drawing.Size(108, 22);
            this.txtBairroProfessor.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 105;
            this.label8.Text = "Cidade";
            // 
            // txtCidadeProfessor
            // 
            this.txtCidadeProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeProfessor.Location = new System.Drawing.Point(457, 180);
            this.txtCidadeProfessor.Name = "txtCidadeProfessor";
            this.txtCidadeProfessor.Size = new System.Drawing.Size(148, 22);
            this.txtCidadeProfessor.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(615, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 107;
            this.label9.Text = "Estado";
            // 
            // txtEstadoProfessor
            // 
            this.txtEstadoProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoProfessor.Location = new System.Drawing.Point(618, 180);
            this.txtEstadoProfessor.Name = "txtEstadoProfessor";
            this.txtEstadoProfessor.Size = new System.Drawing.Size(87, 22);
            this.txtEstadoProfessor.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 109;
            this.label10.Text = "CPF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(455, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 110;
            this.label11.Text = "E-mail";
            // 
            // txtEmailProfessor
            // 
            this.txtEmailProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProfessor.Location = new System.Drawing.Point(458, 230);
            this.txtEmailProfessor.Name = "txtEmailProfessor";
            this.txtEmailProfessor.Size = new System.Drawing.Size(247, 22);
            this.txtEmailProfessor.TabIndex = 111;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(565, 330);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(140, 22);
            this.txtSenha.TabIndex = 182;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 181;
            this.label15.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(333, 330);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 22);
            this.txtUsuario.TabIndex = 180;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(330, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 179;
            this.label16.Text = "Usuário";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(334, 283);
            this.txtTelefone.Mask = "(00)000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(105, 22);
            this.txtTelefone.TabIndex = 183;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(615, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 184;
            this.label13.Text = "Valor hora/aula";
            // 
            // txtValorHoraAula
            // 
            this.txtValorHoraAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHoraAula.Location = new System.Drawing.Point(618, 282);
            this.txtValorHoraAula.Name = "txtValorHoraAula";
            this.txtValorHoraAula.Size = new System.Drawing.Size(87, 22);
            this.txtValorHoraAula.TabIndex = 185;
            // 
            // FormCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 436);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorHoraAula);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboFormacaoProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfressor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCPFProfessor);
            this.Controls.Add(this.txtNumProfessor);
            this.Controls.Add(this.txtCEPProfessor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNascimentoProfessor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBairroProfessor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidadeProfessor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstadoProfessor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmailProfessor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProfessor);
            this.Controls.Add(this.panel2);
            this.Name = "FormCadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.FormCadastroProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboFormacaoProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProfressor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCPFProfessor;
        private System.Windows.Forms.TextBox txtNumProfessor;
        private System.Windows.Forms.MaskedTextBox txtCEPProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNascimentoProfessor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairroProfessor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidadeProfessor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstadoProfessor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmailProfessor;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorHoraAula;
    }
}