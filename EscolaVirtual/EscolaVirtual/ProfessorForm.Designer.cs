namespace EscolaVirtual
{
    partial class ProfessorForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDarNotas = new System.Windows.Forms.TabPage();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNotas = new System.Windows.Forms.ListBox();
            this.btnDarNota = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cbDisciplinas = new System.Windows.Forms.ComboBox();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.txtNovaInfo = new System.Windows.Forms.TextBox();
            this.lblNovaInfo = new System.Windows.Forms.Label();
            this.lvwHistorico = new System.Windows.Forms.ListView();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpDarNotas.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpDarNotas);
            this.tcMain.Controls.Add(this.tpDadosPessoais);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(779, 466);
            this.tcMain.TabIndex = 8;
            // 
            // tpDarNotas
            // 
            this.tpDarNotas.Controls.Add(this.lblTurma);
            this.tpDarNotas.Controls.Add(this.label1);
            this.tpDarNotas.Controls.Add(this.label2);
            this.tpDarNotas.Controls.Add(this.label3);
            this.tpDarNotas.Controls.Add(this.lbNotas);
            this.tpDarNotas.Controls.Add(this.btnDarNota);
            this.tpDarNotas.Controls.Add(this.txtNota);
            this.tpDarNotas.Controls.Add(this.cbDisciplinas);
            this.tpDarNotas.Controls.Add(this.cbAluno);
            this.tpDarNotas.Location = new System.Drawing.Point(4, 29);
            this.tpDarNotas.Name = "tpDarNotas";
            this.tpDarNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpDarNotas.Size = new System.Drawing.Size(771, 433);
            this.tpDarNotas.TabIndex = 0;
            this.tpDarNotas.Text = "Dar E Ver Notas";
            this.tpDarNotas.UseVisualStyleBackColor = true;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.label4);
            this.tpDadosPessoais.Controls.Add(this.comboBox1);
            this.tpDadosPessoais.Controls.Add(this.btnAlterar);
            this.tpDadosPessoais.Controls.Add(this.lblHistorico);
            this.tpDadosPessoais.Controls.Add(this.lvwHistorico);
            this.tpDadosPessoais.Controls.Add(this.lblNovaInfo);
            this.tpDadosPessoais.Controls.Add(this.txtNovaInfo);
            this.tpDadosPessoais.Controls.Add(this.lbInfo);
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 29);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(771, 433);
            this.tpDadosPessoais.TabIndex = 1;
            this.tpDadosPessoais.Text = "Alterar Dados Pessoais";
            this.tpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Disciplinas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aluno";
            // 
            // lbNotas
            // 
            this.lbNotas.FormattingEnabled = true;
            this.lbNotas.HorizontalScrollbar = true;
            this.lbNotas.ItemHeight = 20;
            this.lbNotas.Location = new System.Drawing.Point(446, 18);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(298, 384);
            this.lbNotas.TabIndex = 12;
            // 
            // btnDarNota
            // 
            this.btnDarNota.Enabled = false;
            this.btnDarNota.Location = new System.Drawing.Point(24, 246);
            this.btnDarNota.Name = "btnDarNota";
            this.btnDarNota.Size = new System.Drawing.Size(97, 60);
            this.btnDarNota.TabIndex = 11;
            this.btnDarNota.Text = "Dar Nota";
            this.btnDarNota.UseVisualStyleBackColor = true;
            this.btnDarNota.Click += new System.EventHandler(this.btnDarNota_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(24, 174);
            this.txtNota.MaxLength = 4;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(122, 26);
            this.txtNota.TabIndex = 10;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Location = new System.Drawing.Point(195, 83);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(187, 28);
            this.cbDisciplinas.TabIndex = 9;
            // 
            // cbAluno
            // 
            this.cbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(6, 83);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(156, 28);
            this.cbAluno.TabIndex = 8;
            this.cbAluno.SelectedIndexChanged += new System.EventHandler(this.cbAluno_SelectedIndexChanged);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(37, 18);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(62, 20);
            this.lblTurma.TabIndex = 16;
            this.lblTurma.Text = "Turma: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 484);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 51);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.HorizontalScrollbar = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(6, 31);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(294, 384);
            this.lbInfo.TabIndex = 2;
            // 
            // txtNovaInfo
            // 
            this.txtNovaInfo.Location = new System.Drawing.Point(332, 197);
            this.txtNovaInfo.MaxLength = 9;
            this.txtNovaInfo.Name = "txtNovaInfo";
            this.txtNovaInfo.Size = new System.Drawing.Size(167, 26);
            this.txtNovaInfo.TabIndex = 3;
            this.txtNovaInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNovaInfo
            // 
            this.lblNovaInfo.AutoSize = true;
            this.lblNovaInfo.Location = new System.Drawing.Point(332, 174);
            this.lblNovaInfo.Name = "lblNovaInfo";
            this.lblNovaInfo.Size = new System.Drawing.Size(104, 20);
            this.lblNovaInfo.TabIndex = 8;
            this.lblNovaInfo.Text = "Novos Dados";
            this.lblNovaInfo.Click += new System.EventHandler(this.lblContactoAlterar_Click);
            // 
            // lvwHistorico
            // 
            this.lvwHistorico.HideSelection = false;
            this.lvwHistorico.Location = new System.Drawing.Point(536, 31);
            this.lvwHistorico.Name = "lvwHistorico";
            this.lvwHistorico.Size = new System.Drawing.Size(216, 384);
            this.lvwHistorico.TabIndex = 9;
            this.lvwHistorico.UseCompatibleStateImageBehavior = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(532, 8);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(71, 20);
            this.lblHistorico.TabIndex = 10;
            this.lblHistorico.Text = "Historico";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(341, 253);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 51);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contacto",
            "Morada",
            "Passowrd"});
            this.comboBox1.Location = new System.Drawing.Point(332, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo";
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 545);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcMain);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            this.Shown += new System.EventHandler(this.ProfessorForm_Shown);
            this.tcMain.ResumeLayout(false);
            this.tpDarNotas.ResumeLayout(false);
            this.tpDarNotas.PerformLayout();
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDarNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbNotas;
        private System.Windows.Forms.Button btnDarNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cbDisciplinas;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.TabPage tpDadosPessoais;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TextBox txtNovaInfo;
        private System.Windows.Forms.Label lblNovaInfo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.ListView lvwHistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}