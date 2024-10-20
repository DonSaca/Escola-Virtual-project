
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
            this.tpPedidosAlteracao = new System.Windows.Forms.TabPage();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnNegar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwPedidos = new System.Windows.Forms.ListView();
            this.tcMain.SuspendLayout();
            this.tpCriarTurma.SuspendLayout();
            this.tpProfessor.SuspendLayout();
            this.tpAluno.SuspendLayout();
            this.tpPedidosAlteracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpCriarTurma);
            this.tcMain.Controls.Add(this.tpProfessor);
            this.tcMain.Controls.Add(this.tpAluno);
            this.tcMain.Controls.Add(this.tpPedidosAlteracao);
            this.tcMain.Location = new System.Drawing.Point(14, 15);
            this.tcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(873, 511);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpCriarTurma
            // 
            this.tpCriarTurma.Controls.Add(this.lbTurmas);
            this.tpCriarTurma.Controls.Add(this.lblAno);
            this.tpCriarTurma.Controls.Add(this.cbAnos);
            this.tpCriarTurma.Controls.Add(this.btnCriarTurma);
            this.tpCriarTurma.Controls.Add(this.txtNomeTurma);
            this.tpCriarTurma.Controls.Add(this.lblNomeTurma);
            this.tpCriarTurma.Location = new System.Drawing.Point(4, 29);
            this.tpCriarTurma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCriarTurma.Name = "tpCriarTurma";
            this.tpCriarTurma.Size = new System.Drawing.Size(865, 478);
            this.tpCriarTurma.TabIndex = 2;
            this.tpCriarTurma.Text = "Criar Turma";
            this.tpCriarTurma.UseVisualStyleBackColor = true;
            this.tpCriarTurma.Click += new System.EventHandler(this.tpCriarTurma_Click);
            // 
            // lbTurmas
            // 
            this.lbTurmas.FormattingEnabled = true;
            this.lbTurmas.HorizontalScrollbar = true;
            this.lbTurmas.ItemHeight = 20;
            this.lbTurmas.Location = new System.Drawing.Point(367, 56);
            this.lbTurmas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTurmas.Name = "lbTurmas";
            this.lbTurmas.Size = new System.Drawing.Size(298, 404);
            this.lbTurmas.TabIndex = 5;
            this.lbTurmas.SelectedIndexChanged += new System.EventHandler(this.lbTurmas_SelectedIndexChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(189, 65);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(38, 20);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // cbAnos
            // 
            this.cbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnos.FormattingEnabled = true;
            this.cbAnos.Location = new System.Drawing.Point(192, 91);
            this.cbAnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAnos.Name = "cbAnos";
            this.cbAnos.Size = new System.Drawing.Size(136, 28);
            this.cbAnos.TabIndex = 3;
            this.cbAnos.SelectedIndexChanged += new System.EventHandler(this.cbAnos_SelectedIndexChanged);
            // 
            // btnCriarTurma
            // 
            this.btnCriarTurma.Enabled = false;
            this.btnCriarTurma.Location = new System.Drawing.Point(30, 202);
            this.btnCriarTurma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCriarTurma.Name = "btnCriarTurma";
            this.btnCriarTurma.Size = new System.Drawing.Size(105, 46);
            this.btnCriarTurma.TabIndex = 2;
            this.btnCriarTurma.Text = "Criar Turma";
            this.btnCriarTurma.UseVisualStyleBackColor = true;
            this.btnCriarTurma.Click += new System.EventHandler(this.btnCriarTurma_Click);
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(30, 91);
            this.txtNomeTurma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(112, 26);
            this.txtNomeTurma.TabIndex = 1;
            this.txtNomeTurma.TextChanged += new System.EventHandler(this.txtNomeTurma_TextChanged);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Location = new System.Drawing.Point(27, 65);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(51, 20);
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
            this.tpProfessor.Location = new System.Drawing.Point(4, 29);
            this.tpProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpProfessor.Name = "tpProfessor";
            this.tpProfessor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpProfessor.Size = new System.Drawing.Size(865, 478);
            this.tpProfessor.TabIndex = 0;
            this.tpProfessor.Text = "Criar Professor";
            this.tpProfessor.UseVisualStyleBackColor = true;
            // 
            // lbProfessoresProfessor
            // 
            this.lbProfessoresProfessor.FormattingEnabled = true;
            this.lbProfessoresProfessor.HorizontalScrollbar = true;
            this.lbProfessoresProfessor.ItemHeight = 20;
            this.lbProfessoresProfessor.Location = new System.Drawing.Point(573, 21);
            this.lbProfessoresProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbProfessoresProfessor.Name = "lbProfessoresProfessor";
            this.lbProfessoresProfessor.Size = new System.Drawing.Size(271, 424);
            this.lbProfessoresProfessor.TabIndex = 25;
            // 
            // btnCriarProfessor
            // 
            this.btnCriarProfessor.Enabled = false;
            this.btnCriarProfessor.Location = new System.Drawing.Point(22, 308);
            this.btnCriarProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCriarProfessor.Name = "btnCriarProfessor";
            this.btnCriarProfessor.Size = new System.Drawing.Size(90, 61);
            this.btnCriarProfessor.TabIndex = 24;
            this.btnCriarProfessor.Text = "Criar Professor";
            this.btnCriarProfessor.UseVisualStyleBackColor = true;
            this.btnCriarProfessor.Click += new System.EventHandler(this.btnCriarProfessor_Click);
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Location = new System.Drawing.Point(404, 56);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(54, 20);
            this.lblTurmas.TabIndex = 20;
            this.lblTurmas.Text = "Turma";
            // 
            // cbTurmasProfessor
            // 
            this.cbTurmasProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurmasProfessor.FormattingEnabled = true;
            this.cbTurmasProfessor.Location = new System.Drawing.Point(407, 81);
            this.cbTurmasProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTurmasProfessor.Name = "cbTurmasProfessor";
            this.cbTurmasProfessor.Size = new System.Drawing.Size(136, 28);
            this.cbTurmasProfessor.TabIndex = 19;
            this.cbTurmasProfessor.SelectedIndexChanged += new System.EventHandler(this.cbTurmasProfessor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // txtPasswordProfessor
            // 
            this.txtPasswordProfessor.Location = new System.Drawing.Point(212, 251);
            this.txtPasswordProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordProfessor.Name = "txtPasswordProfessor";
            this.txtPasswordProfessor.Size = new System.Drawing.Size(160, 26);
            this.txtPasswordProfessor.TabIndex = 17;
            // 
            // lblContactoProfessor
            // 
            this.lblContactoProfessor.AutoSize = true;
            this.lblContactoProfessor.Location = new System.Drawing.Point(208, 56);
            this.lblContactoProfessor.Name = "lblContactoProfessor";
            this.lblContactoProfessor.Size = new System.Drawing.Size(74, 20);
            this.lblContactoProfessor.TabIndex = 16;
            this.lblContactoProfessor.Text = "Contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "User";
            // 
            // lblNIFprofessor
            // 
            this.lblNIFprofessor.AutoSize = true;
            this.lblNIFprofessor.Location = new System.Drawing.Point(19, 226);
            this.lblNIFprofessor.Name = "lblNIFprofessor";
            this.lblNIFprofessor.Size = new System.Drawing.Size(35, 20);
            this.lblNIFprofessor.TabIndex = 14;
            this.lblNIFprofessor.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // txtUserProfessor
            // 
            this.txtUserProfessor.Location = new System.Drawing.Point(212, 172);
            this.txtUserProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserProfessor.Name = "txtUserProfessor";
            this.txtUserProfessor.Size = new System.Drawing.Size(112, 26);
            this.txtUserProfessor.TabIndex = 11;
            // 
            // txtContactoProfessor
            // 
            this.txtContactoProfessor.Location = new System.Drawing.Point(212, 81);
            this.txtContactoProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactoProfessor.Name = "txtContactoProfessor";
            this.txtContactoProfessor.Size = new System.Drawing.Size(160, 26);
            this.txtContactoProfessor.TabIndex = 10;
            this.txtContactoProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoProfessor_KeyPress);
            // 
            // txtNIFprofessor
            // 
            this.txtNIFprofessor.Location = new System.Drawing.Point(22, 251);
            this.txtNIFprofessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIFprofessor.Name = "txtNIFprofessor";
            this.txtNIFprofessor.Size = new System.Drawing.Size(112, 26);
            this.txtNIFprofessor.TabIndex = 9;
            this.txtNIFprofessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIFprofessor_KeyPress);
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(22, 81);
            this.txtNomeProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(112, 26);
            this.txtNomeProfessor.TabIndex = 8;
            // 
            // txtNumFunc
            // 
            this.txtNumFunc.Location = new System.Drawing.Point(22, 159);
            this.txtNumFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumFunc.Name = "txtNumFunc";
            this.txtNumFunc.Size = new System.Drawing.Size(112, 26);
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
            this.tpAluno.Location = new System.Drawing.Point(4, 29);
            this.tpAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAluno.Name = "tpAluno";
            this.tpAluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAluno.Size = new System.Drawing.Size(865, 478);
            this.tpAluno.TabIndex = 1;
            this.tpAluno.Text = "Criar Aluno";
            this.tpAluno.UseVisualStyleBackColor = true;
            // 
            // lbAlunosAluno
            // 
            this.lbAlunosAluno.FormattingEnabled = true;
            this.lbAlunosAluno.HorizontalScrollbar = true;
            this.lbAlunosAluno.ItemHeight = 20;
            this.lbAlunosAluno.Location = new System.Drawing.Point(575, 29);
            this.lbAlunosAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbAlunosAluno.Name = "lbAlunosAluno";
            this.lbAlunosAluno.Size = new System.Drawing.Size(271, 424);
            this.lbAlunosAluno.TabIndex = 28;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(407, 29);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(54, 20);
            this.lblTurma.TabIndex = 27;
            this.lblTurma.Text = "Turma";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(279, 30);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(74, 20);
            this.lblContacto.TabIndex = 26;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // cbTurmasAluno
            // 
            this.cbTurmasAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurmasAluno.FormattingEnabled = true;
            this.cbTurmasAluno.Location = new System.Drawing.Point(411, 52);
            this.cbTurmasAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTurmasAluno.Name = "cbTurmasAluno";
            this.cbTurmasAluno.Size = new System.Drawing.Size(136, 28);
            this.cbTurmasAluno.TabIndex = 24;
            this.cbTurmasAluno.SelectedIndexChanged += new System.EventHandler(this.cbTurmasAluno_SelectedIndexChanged);
            // 
            // btnCriarAluno
            // 
            this.btnCriarAluno.Enabled = false;
            this.btnCriarAluno.Location = new System.Drawing.Point(261, 314);
            this.btnCriarAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCriarAluno.Name = "btnCriarAluno";
            this.btnCriarAluno.Size = new System.Drawing.Size(90, 61);
            this.btnCriarAluno.TabIndex = 23;
            this.btnCriarAluno.Text = "Criar Aluno";
            this.btnCriarAluno.UseVisualStyleBackColor = true;
            this.btnCriarAluno.Click += new System.EventHandler(this.btnCriarAluno_Click);
            // 
            // txtContactoAluno
            // 
            this.txtContactoAluno.Location = new System.Drawing.Point(261, 55);
            this.txtContactoAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactoAluno.Name = "txtContactoAluno";
            this.txtContactoAluno.Size = new System.Drawing.Size(112, 26);
            this.txtContactoAluno.TabIndex = 22;
            this.txtContactoAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoAluno_KeyPress);
            // 
            // txtNumAluno
            // 
            this.txtNumAluno.Location = new System.Drawing.Point(254, 176);
            this.txtNumAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumAluno.Name = "txtNumAluno";
            this.txtNumAluno.Size = new System.Drawing.Size(112, 26);
            this.txtNumAluno.TabIndex = 21;
            this.txtNumAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAluno_KeyPress);
            // 
            // txtNIfAluno
            // 
            this.txtNIfAluno.Location = new System.Drawing.Point(35, 176);
            this.txtNIfAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIfAluno.Name = "txtNIfAluno";
            this.txtNIfAluno.Size = new System.Drawing.Size(112, 26);
            this.txtNIfAluno.TabIndex = 20;
            this.txtNIfAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIfAluno_KeyPress);
            // 
            // txtPasswordAluno
            // 
            this.txtPasswordAluno.Location = new System.Drawing.Point(35, 392);
            this.txtPasswordAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordAluno.Name = "txtPasswordAluno";
            this.txtPasswordAluno.Size = new System.Drawing.Size(112, 26);
            this.txtPasswordAluno.TabIndex = 19;
            // 
            // txtUserAluno
            // 
            this.txtUserAluno.Location = new System.Drawing.Point(35, 295);
            this.txtUserAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserAluno.Name = "txtUserAluno";
            this.txtUserAluno.Size = new System.Drawing.Size(112, 26);
            this.txtUserAluno.TabIndex = 18;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(35, 55);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(112, 26);
            this.txtNomeAluno.TabIndex = 17;
            // 
            // lblNumeroAluno
            // 
            this.lblNumeroAluno.AutoSize = true;
            this.lblNumeroAluno.Location = new System.Drawing.Point(258, 135);
            this.lblNumeroAluno.Name = "lblNumeroAluno";
            this.lblNumeroAluno.Size = new System.Drawing.Size(108, 20);
            this.lblNumeroAluno.TabIndex = 16;
            this.lblNumeroAluno.Text = "Numero aluno";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 346);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Passowrd";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(51, 242);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(51, 135);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(35, 20);
            this.lblNIF.TabIndex = 13;
            this.lblNIF.Text = "NIF";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(18, 534);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 54);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tpPedidosAlteracao
            // 
            this.tpPedidosAlteracao.Controls.Add(this.lvwPedidos);
            this.tpPedidosAlteracao.Controls.Add(this.label3);
            this.tpPedidosAlteracao.Controls.Add(this.btnNegar);
            this.tpPedidosAlteracao.Controls.Add(this.btnAprovar);
            this.tpPedidosAlteracao.Location = new System.Drawing.Point(4, 29);
            this.tpPedidosAlteracao.Name = "tpPedidosAlteracao";
            this.tpPedidosAlteracao.Size = new System.Drawing.Size(865, 478);
            this.tpPedidosAlteracao.TabIndex = 3;
            this.tpPedidosAlteracao.Text = "Pedidos de Alterações ";
            this.tpPedidosAlteracao.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.Green;
            this.btnAprovar.Location = new System.Drawing.Point(466, 227);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(119, 95);
            this.btnAprovar.TabIndex = 5;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // btnNegar
            // 
            this.btnNegar.BackColor = System.Drawing.Color.Red;
            this.btnNegar.Location = new System.Drawing.Point(615, 227);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(119, 95);
            this.btnNegar.TabIndex = 6;
            this.btnNegar.Text = "Negar";
            this.btnNegar.UseVisualStyleBackColor = false;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleciona Um pedido na lista à esqueda depois aprova ou nega";
            // 
            // lvwPedidos
            // 
            this.lvwPedidos.HideSelection = false;
            this.lvwPedidos.Location = new System.Drawing.Point(14, 19);
            this.lvwPedidos.Name = "lvwPedidos";
            this.lvwPedidos.Size = new System.Drawing.Size(377, 438);
            this.lvwPedidos.TabIndex = 8;
            this.lvwPedidos.UseCompatibleStateImageBehavior = false;
            this.lvwPedidos.View = System.Windows.Forms.View.Details;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 629);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.tpPedidosAlteracao.ResumeLayout(false);
            this.tpPedidosAlteracao.PerformLayout();
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
        private System.Windows.Forms.ListBox lbProfessoresProfessor;
        private System.Windows.Forms.ListBox lbAlunosAluno;
        private System.Windows.Forms.TabPage tpPedidosAlteracao;
        private System.Windows.Forms.Button btnNegar;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwPedidos;
    }
}

