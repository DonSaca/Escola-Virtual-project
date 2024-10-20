
namespace EscolaVirtual
{
    partial class AdminForm
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
            this.tpCriarTurma = new System.Windows.Forms.TabPage();
            this.lblDisciplinasTurma = new System.Windows.Forms.Label();
            this.lblProfessorTurma = new System.Windows.Forms.Label();
            this.lbDisciplinasTurma = new System.Windows.Forms.ListBox();
            this.lbProfessorTurma = new System.Windows.Forms.ListBox();
            this.lbTurmas = new System.Windows.Forms.ListBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbAnos = new System.Windows.Forms.ComboBox();
            this.btnCriarTurma = new System.Windows.Forms.Button();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.tpProfessor = new System.Windows.Forms.TabPage();
            this.lbProfessoresProfessor = new System.Windows.Forms.ListBox();
            this.btnCriarProfessor = new System.Windows.Forms.Button();
            this.lblTurmas = new System.Windows.Forms.Label();
            this.cbTurmasProfessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordProfessor = new System.Windows.Forms.TextBox();
            this.lblContactoProfessor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNIFprofessor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserProfessor = new System.Windows.Forms.TextBox();
            this.txtContactoProfessor = new System.Windows.Forms.TextBox();
            this.txtNIFprofessor = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.txtNumFunc = new System.Windows.Forms.TextBox();
            this.tpAluno = new System.Windows.Forms.TabPage();
            this.lbAlunosAluno = new System.Windows.Forms.ListBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbTurmasAluno = new System.Windows.Forms.ComboBox();
            this.btnCriarAluno = new System.Windows.Forms.Button();
            this.txtContactoAluno = new System.Windows.Forms.TextBox();
            this.txtNumAluno = new System.Windows.Forms.TextBox();
            this.txtNIfAluno = new System.Windows.Forms.TextBox();
            this.txtPasswordAluno = new System.Windows.Forms.TextBox();
            this.txtUserAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNumeroAluno = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpCriarTurma.SuspendLayout();
            this.tpProfessor.SuspendLayout();
            this.tpAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpCriarTurma);
            this.tcMain.Controls.Add(this.tpProfessor);
            this.tcMain.Controls.Add(this.tpAluno);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(776, 409);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpCriarTurma
            // 
            this.tpCriarTurma.Controls.Add(this.lblDisciplinasTurma);
            this.tpCriarTurma.Controls.Add(this.lblProfessorTurma);
            this.tpCriarTurma.Controls.Add(this.lbDisciplinasTurma);
            this.tpCriarTurma.Controls.Add(this.lbProfessorTurma);
            this.tpCriarTurma.Controls.Add(this.lbTurmas);
            this.tpCriarTurma.Controls.Add(this.lblAno);
            this.tpCriarTurma.Controls.Add(this.cbAnos);
            this.tpCriarTurma.Controls.Add(this.btnCriarTurma);
            this.tpCriarTurma.Controls.Add(this.txtNomeTurma);
            this.tpCriarTurma.Controls.Add(this.lblNomeTurma);
            this.tpCriarTurma.Location = new System.Drawing.Point(4, 25);
            this.tpCriarTurma.Name = "tpCriarTurma";
            this.tpCriarTurma.Size = new System.Drawing.Size(768, 380);
            this.tpCriarTurma.TabIndex = 2;
            this.tpCriarTurma.Text = "Criar Turma";
            this.tpCriarTurma.UseVisualStyleBackColor = true;
            this.tpCriarTurma.Click += new System.EventHandler(this.tpCriarTurma_Click);
            // 
            // lblDisciplinasTurma
            // 
            this.lblDisciplinasTurma.AutoSize = true;
            this.lblDisciplinasTurma.Location = new System.Drawing.Point(596, 22);
            this.lblDisciplinasTurma.Name = "lblDisciplinasTurma";
            this.lblDisciplinasTurma.Size = new System.Drawing.Size(75, 17);
            this.lblDisciplinasTurma.TabIndex = 9;
            this.lblDisciplinasTurma.Text = "Disciplinas";
            // 
            // lblProfessorTurma
            // 
            this.lblProfessorTurma.AutoSize = true;
            this.lblProfessorTurma.Location = new System.Drawing.Point(445, 22);
            this.lblProfessorTurma.Name = "lblProfessorTurma";
            this.lblProfessorTurma.Size = new System.Drawing.Size(84, 17);
            this.lblProfessorTurma.TabIndex = 8;
            this.lblProfessorTurma.Text = "Professores";
            // 
            // lbDisciplinasTurma
            // 
            this.lbDisciplinasTurma.FormattingEnabled = true;
            this.lbDisciplinasTurma.HorizontalScrollbar = true;
            this.lbDisciplinasTurma.ItemHeight = 16;
            this.lbDisciplinasTurma.Location = new System.Drawing.Point(599, 45);
            this.lbDisciplinasTurma.Name = "lbDisciplinasTurma";
            this.lbDisciplinasTurma.Size = new System.Drawing.Size(149, 324);
            this.lbDisciplinasTurma.TabIndex = 7;
            // 
            // lbProfessorTurma
            // 
            this.lbProfessorTurma.FormattingEnabled = true;
            this.lbProfessorTurma.HorizontalScrollbar = true;
            this.lbProfessorTurma.ItemHeight = 16;
            this.lbProfessorTurma.Location = new System.Drawing.Point(444, 45);
            this.lbProfessorTurma.Name = "lbProfessorTurma";
            this.lbProfessorTurma.Size = new System.Drawing.Size(149, 324);
            this.lbProfessorTurma.TabIndex = 6;
            // 
            // lbTurmas
            // 
            this.lbTurmas.FormattingEnabled = true;
            this.lbTurmas.HorizontalScrollbar = true;
            this.lbTurmas.ItemHeight = 16;
            this.lbTurmas.Location = new System.Drawing.Point(326, 45);
            this.lbTurmas.Name = "lbTurmas";
            this.lbTurmas.Size = new System.Drawing.Size(112, 324);
            this.lbTurmas.TabIndex = 5;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(168, 52);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(33, 17);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // cbAnos
            // 
            this.cbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnos.FormattingEnabled = true;
            this.cbAnos.Location = new System.Drawing.Point(171, 73);
            this.cbAnos.Name = "cbAnos";
            this.cbAnos.Size = new System.Drawing.Size(121, 24);
            this.cbAnos.TabIndex = 3;
            this.cbAnos.SelectedIndexChanged += new System.EventHandler(this.cbAnos_SelectedIndexChanged);
            // 
            // btnCriarTurma
            // 
            this.btnCriarTurma.Enabled = false;
            this.btnCriarTurma.Location = new System.Drawing.Point(27, 162);
            this.btnCriarTurma.Name = "btnCriarTurma";
            this.btnCriarTurma.Size = new System.Drawing.Size(93, 37);
            this.btnCriarTurma.TabIndex = 2;
            this.btnCriarTurma.Text = "Criar Turma";
            this.btnCriarTurma.UseVisualStyleBackColor = true;
            this.btnCriarTurma.Click += new System.EventHandler(this.btnCriarTurma_Click);
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(27, 73);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(100, 22);
            this.txtNomeTurma.TabIndex = 1;
            this.txtNomeTurma.TextChanged += new System.EventHandler(this.txtNomeTurma_TextChanged);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Location = new System.Drawing.Point(24, 52);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(45, 17);
            this.lblNomeTurma.TabIndex = 0;
            this.lblNomeTurma.Text = "Nome";
            // 
            // tpProfessor
            // 
            this.tpProfessor.Controls.Add(this.lbProfessoresProfessor);
            this.tpProfessor.Controls.Add(this.btnCriarProfessor);
            this.tpProfessor.Controls.Add(this.lblTurmas);
            this.tpProfessor.Controls.Add(this.cbTurmasProfessor);
            this.tpProfessor.Controls.Add(this.label6);
            this.tpProfessor.Controls.Add(this.txtPasswordProfessor);
            this.tpProfessor.Controls.Add(this.lblContactoProfessor);
            this.tpProfessor.Controls.Add(this.label4);
            this.tpProfessor.Controls.Add(this.lblNIFprofessor);
            this.tpProfessor.Controls.Add(this.label2);
            this.tpProfessor.Controls.Add(this.label1);
            this.tpProfessor.Controls.Add(this.txtUserProfessor);
            this.tpProfessor.Controls.Add(this.txtContactoProfessor);
            this.tpProfessor.Controls.Add(this.txtNIFprofessor);
            this.tpProfessor.Controls.Add(this.txtNomeProfessor);
            this.tpProfessor.Controls.Add(this.txtNumFunc);
            this.tpProfessor.Location = new System.Drawing.Point(4, 25);
            this.tpProfessor.Name = "tpProfessor";
            this.tpProfessor.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpProfessor.Size = new System.Drawing.Size(768, 380);
            this.tpProfessor.TabIndex = 0;
            this.tpProfessor.Text = "Criar Professor";
            this.tpProfessor.UseVisualStyleBackColor = true;
            // 
            // lbProfessoresProfessor
            // 
            this.lbProfessoresProfessor.FormattingEnabled = true;
            this.lbProfessoresProfessor.HorizontalScrollbar = true;
            this.lbProfessoresProfessor.ItemHeight = 16;
            this.lbProfessoresProfessor.Location = new System.Drawing.Point(509, 17);
            this.lbProfessoresProfessor.Name = "lbProfessoresProfessor";
            this.lbProfessoresProfessor.Size = new System.Drawing.Size(241, 340);
            this.lbProfessoresProfessor.TabIndex = 25;
            // 
            // btnCriarProfessor
            // 
            this.btnCriarProfessor.Enabled = false;
            this.btnCriarProfessor.Location = new System.Drawing.Point(20, 246);
            this.btnCriarProfessor.Name = "btnCriarProfessor";
            this.btnCriarProfessor.Size = new System.Drawing.Size(80, 49);
            this.btnCriarProfessor.TabIndex = 24;
            this.btnCriarProfessor.Text = "Criar Professor";
            this.btnCriarProfessor.UseVisualStyleBackColor = true;
            this.btnCriarProfessor.Click += new System.EventHandler(this.btnCriarProfessor_Click);
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Location = new System.Drawing.Point(359, 45);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(49, 17);
            this.lblTurmas.TabIndex = 20;
            this.lblTurmas.Text = "Turma";
            // 
            // cbTurmasProfessor
            // 
            this.cbTurmasProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurmasProfessor.FormattingEnabled = true;
            this.cbTurmasProfessor.Location = new System.Drawing.Point(362, 65);
            this.cbTurmasProfessor.Name = "cbTurmasProfessor";
            this.cbTurmasProfessor.Size = new System.Drawing.Size(121, 24);
            this.cbTurmasProfessor.TabIndex = 19;
            this.cbTurmasProfessor.SelectedIndexChanged += new System.EventHandler(this.cbTurmasProfessor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // txtPasswordProfessor
            // 
            this.txtPasswordProfessor.Location = new System.Drawing.Point(188, 201);
            this.txtPasswordProfessor.Name = "txtPasswordProfessor";
            this.txtPasswordProfessor.Size = new System.Drawing.Size(143, 22);
            this.txtPasswordProfessor.TabIndex = 17;
            // 
            // lblContactoProfessor
            // 
            this.lblContactoProfessor.AutoSize = true;
            this.lblContactoProfessor.Location = new System.Drawing.Point(185, 45);
            this.lblContactoProfessor.Name = "lblContactoProfessor";
            this.lblContactoProfessor.Size = new System.Drawing.Size(64, 17);
            this.lblContactoProfessor.TabIndex = 16;
            this.lblContactoProfessor.Text = "Contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "User";
            // 
            // lblNIFprofessor
            // 
            this.lblNIFprofessor.AutoSize = true;
            this.lblNIFprofessor.Location = new System.Drawing.Point(17, 181);
            this.lblNIFprofessor.Name = "lblNIFprofessor";
            this.lblNIFprofessor.Size = new System.Drawing.Size(29, 17);
            this.lblNIFprofessor.TabIndex = 14;
            this.lblNIFprofessor.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // txtUserProfessor
            // 
            this.txtUserProfessor.Location = new System.Drawing.Point(188, 138);
            this.txtUserProfessor.Name = "txtUserProfessor";
            this.txtUserProfessor.Size = new System.Drawing.Size(100, 22);
            this.txtUserProfessor.TabIndex = 11;
            // 
            // txtContactoProfessor
            // 
            this.txtContactoProfessor.Location = new System.Drawing.Point(188, 65);
            this.txtContactoProfessor.Name = "txtContactoProfessor";
            this.txtContactoProfessor.Size = new System.Drawing.Size(143, 22);
            this.txtContactoProfessor.TabIndex = 10;
            this.txtContactoProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoProfessor_KeyPress);
            // 
            // txtNIFprofessor
            // 
            this.txtNIFprofessor.Location = new System.Drawing.Point(20, 201);
            this.txtNIFprofessor.Name = "txtNIFprofessor";
            this.txtNIFprofessor.Size = new System.Drawing.Size(100, 22);
            this.txtNIFprofessor.TabIndex = 9;
            this.txtNIFprofessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIFprofessor_KeyPress);
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(20, 65);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProfessor.TabIndex = 8;
            // 
            // txtNumFunc
            // 
            this.txtNumFunc.Location = new System.Drawing.Point(20, 127);
            this.txtNumFunc.Name = "txtNumFunc";
            this.txtNumFunc.Size = new System.Drawing.Size(100, 22);
            this.txtNumFunc.TabIndex = 7;
            this.txtNumFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFunc_KeyPress);
            // 
            // tpAluno
            // 
            this.tpAluno.Controls.Add(this.lbAlunosAluno);
            this.tpAluno.Controls.Add(this.lblTurma);
            this.tpAluno.Controls.Add(this.lblContacto);
            this.tpAluno.Controls.Add(this.lblNome);
            this.tpAluno.Controls.Add(this.cbTurmasAluno);
            this.tpAluno.Controls.Add(this.btnCriarAluno);
            this.tpAluno.Controls.Add(this.txtContactoAluno);
            this.tpAluno.Controls.Add(this.txtNumAluno);
            this.tpAluno.Controls.Add(this.txtNIfAluno);
            this.tpAluno.Controls.Add(this.txtPasswordAluno);
            this.tpAluno.Controls.Add(this.txtUserAluno);
            this.tpAluno.Controls.Add(this.txtNomeAluno);
            this.tpAluno.Controls.Add(this.lblNumeroAluno);
            this.tpAluno.Controls.Add(this.lblPassword);
            this.tpAluno.Controls.Add(this.lblUser);
            this.tpAluno.Controls.Add(this.lblNIF);
            this.tpAluno.Location = new System.Drawing.Point(4, 25);
            this.tpAluno.Name = "tpAluno";
            this.tpAluno.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAluno.Size = new System.Drawing.Size(768, 380);
            this.tpAluno.TabIndex = 1;
            this.tpAluno.Text = "Criar Aluno";
            this.tpAluno.UseVisualStyleBackColor = true;
            // 
            // lbAlunosAluno
            // 
            this.lbAlunosAluno.FormattingEnabled = true;
            this.lbAlunosAluno.HorizontalScrollbar = true;
            this.lbAlunosAluno.ItemHeight = 16;
            this.lbAlunosAluno.Location = new System.Drawing.Point(511, 23);
            this.lbAlunosAluno.Name = "lbAlunosAluno";
            this.lbAlunosAluno.Size = new System.Drawing.Size(241, 340);
            this.lbAlunosAluno.TabIndex = 28;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(362, 23);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(49, 17);
            this.lblTurma.TabIndex = 27;
            this.lblTurma.Text = "Turma";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(248, 24);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(64, 17);
            this.lblContacto.TabIndex = 26;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(45, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // cbTurmasAluno
            // 
            this.cbTurmasAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurmasAluno.FormattingEnabled = true;
            this.cbTurmasAluno.Location = new System.Drawing.Point(365, 42);
            this.cbTurmasAluno.Name = "cbTurmasAluno";
            this.cbTurmasAluno.Size = new System.Drawing.Size(121, 24);
            this.cbTurmasAluno.TabIndex = 24;
            this.cbTurmasAluno.SelectedIndexChanged += new System.EventHandler(this.cbTurmasAluno_SelectedIndexChanged);
            // 
            // btnCriarAluno
            // 
            this.btnCriarAluno.Enabled = false;
            this.btnCriarAluno.Location = new System.Drawing.Point(232, 251);
            this.btnCriarAluno.Name = "btnCriarAluno";
            this.btnCriarAluno.Size = new System.Drawing.Size(80, 49);
            this.btnCriarAluno.TabIndex = 23;
            this.btnCriarAluno.Text = "Criar Aluno";
            this.btnCriarAluno.UseVisualStyleBackColor = true;
            this.btnCriarAluno.Click += new System.EventHandler(this.btnCriarAluno_Click);
            // 
            // txtContactoAluno
            // 
            this.txtContactoAluno.Location = new System.Drawing.Point(232, 44);
            this.txtContactoAluno.Name = "txtContactoAluno";
            this.txtContactoAluno.Size = new System.Drawing.Size(100, 22);
            this.txtContactoAluno.TabIndex = 22;
            this.txtContactoAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoAluno_KeyPress);
            // 
            // txtNumAluno
            // 
            this.txtNumAluno.Location = new System.Drawing.Point(226, 141);
            this.txtNumAluno.Name = "txtNumAluno";
            this.txtNumAluno.Size = new System.Drawing.Size(100, 22);
            this.txtNumAluno.TabIndex = 21;
            this.txtNumAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAluno_KeyPress);
            // 
            // txtNIfAluno
            // 
            this.txtNIfAluno.Location = new System.Drawing.Point(31, 141);
            this.txtNIfAluno.Name = "txtNIfAluno";
            this.txtNIfAluno.Size = new System.Drawing.Size(100, 22);
            this.txtNIfAluno.TabIndex = 20;
            this.txtNIfAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIfAluno_KeyPress);
            // 
            // txtPasswordAluno
            // 
            this.txtPasswordAluno.Location = new System.Drawing.Point(31, 314);
            this.txtPasswordAluno.Name = "txtPasswordAluno";
            this.txtPasswordAluno.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordAluno.TabIndex = 19;
            // 
            // txtUserAluno
            // 
            this.txtUserAluno.Location = new System.Drawing.Point(31, 236);
            this.txtUserAluno.Name = "txtUserAluno";
            this.txtUserAluno.Size = new System.Drawing.Size(100, 22);
            this.txtUserAluno.TabIndex = 18;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(31, 44);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(100, 22);
            this.txtNomeAluno.TabIndex = 17;
            // 
            // lblNumeroAluno
            // 
            this.lblNumeroAluno.AutoSize = true;
            this.lblNumeroAluno.Location = new System.Drawing.Point(229, 108);
            this.lblNumeroAluno.Name = "lblNumeroAluno";
            this.lblNumeroAluno.Size = new System.Drawing.Size(97, 17);
            this.lblNumeroAluno.TabIndex = 16;
            this.lblNumeroAluno.Text = "Numero aluno";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 277);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Passowrd";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(45, 194);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(45, 108);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(29, 17);
            this.lblNIF.TabIndex = 13;
            this.lblNIF.Text = "NIF";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(16, 427);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 43);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 503);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcMain);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.AdminForm_Shown);
            this.tcMain.ResumeLayout(false);
            this.tpCriarTurma.ResumeLayout(false);
            this.tpCriarTurma.PerformLayout();
            this.tpProfessor.ResumeLayout(false);
            this.tpProfessor.PerformLayout();
            this.tpAluno.ResumeLayout(false);
            this.tpAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpProfessor;
        private System.Windows.Forms.Label lblTurmas;
        private System.Windows.Forms.ComboBox cbTurmasProfessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordProfessor;
        private System.Windows.Forms.Label lblContactoProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNIFprofessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserProfessor;
        private System.Windows.Forms.TextBox txtContactoProfessor;
        private System.Windows.Forms.TextBox txtNIFprofessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.TextBox txtNumFunc;
        private System.Windows.Forms.TabPage tpAluno;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbTurmasAluno;
        private System.Windows.Forms.Button btnCriarAluno;
        private System.Windows.Forms.TextBox txtContactoAluno;
        private System.Windows.Forms.TextBox txtNumAluno;
        private System.Windows.Forms.TextBox txtNIfAluno;
        private System.Windows.Forms.TextBox txtPasswordAluno;
        private System.Windows.Forms.TextBox txtUserAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNumeroAluno;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCriarProfessor;
        private System.Windows.Forms.TabPage tpCriarTurma;
        private System.Windows.Forms.ListBox lbTurmas;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbAnos;
        private System.Windows.Forms.Button btnCriarTurma;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.Label lblDisciplinasTurma;
        private System.Windows.Forms.Label lblProfessorTurma;
        private System.Windows.Forms.ListBox lbDisciplinasTurma;
        private System.Windows.Forms.ListBox lbProfessorTurma;
        private System.Windows.Forms.ListBox lbProfessoresProfessor;
        private System.Windows.Forms.ListBox lbAlunosAluno;
    }
}

