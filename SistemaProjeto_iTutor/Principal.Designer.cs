namespace SistemaProjeto_iTutor
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.btnGerenciarCadastros = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.lbFechar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnGerenciarCadastros);
            this.panel1.Controls.Add(this.btnCadastrarProfessor);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAlunos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.lbFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(198, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 425);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "iTutor";
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.btnAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAlunos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlunos.Image")));
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(0, 83);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(198, 34);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "Aluno";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "   Agendar Aulas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.btnCadastrarProfessor.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProfessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.btnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastrarProfessor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProfessor.Image")));
            this.btnCadastrarProfessor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(0, 148);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(198, 34);
            this.btnCadastrarProfessor.TabIndex = 18;
            this.btnCadastrarProfessor.Text = "Professor";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = false;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // btnGerenciarCadastros
            // 
            this.btnGerenciarCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.btnGerenciarCadastros.FlatAppearance.BorderSize = 0;
            this.btnGerenciarCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.btnGerenciarCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarCadastros.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGerenciarCadastros.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerenciarCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarCadastros.Image")));
            this.btnGerenciarCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciarCadastros.Location = new System.Drawing.Point(0, 181);
            this.btnGerenciarCadastros.Name = "btnGerenciarCadastros";
            this.btnGerenciarCadastros.Size = new System.Drawing.Size(198, 34);
            this.btnGerenciarCadastros.TabIndex = 19;
            this.btnGerenciarCadastros.Text = "Utilitários";
            this.btnGerenciarCadastros.UseVisualStyleBackColor = false;
            this.btnGerenciarCadastros.Click += new System.EventHandler(this.BtnGerenciarCadastros_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Relatório";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(44)))));
            this.btnDeslogar.FlatAppearance.BorderSize = 0;
            this.btnDeslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDeslogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeslogar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.Image")));
            this.btnDeslogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeslogar.Location = new System.Drawing.Point(0, 422);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(198, 34);
            this.btnDeslogar.TabIndex = 21;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // lbFechar
            // 
            this.lbFechar.AutoSize = true;
            this.lbFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFechar.Image = ((System.Drawing.Image)(resources.GetObject("lbFechar.Image")));
            this.lbFechar.Location = new System.Drawing.Point(675, 9);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(23, 18);
            this.lbFechar.TabIndex = 17;
            this.lbFechar.Text = "   ";
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnGerenciarCadastros;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Label lbFechar;
    }
}