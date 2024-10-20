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
            this.tcMain.SuspendLayout();
            this.tpDarNotas.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(41, 114);
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
            this.lbNotas.ItemHeight = 20;
            this.lbNotas.Location = new System.Drawing.Point(348, 18);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(269, 384);
            this.lbNotas.TabIndex = 12;
            // 
            // btnDarNota
            // 
            this.btnDarNota.Location = new System.Drawing.Point(42, 195);
            this.btnDarNota.Name = "btnDarNota";
            this.btnDarNota.Size = new System.Drawing.Size(75, 51);
            this.btnDarNota.TabIndex = 11;
            this.btnDarNota.Text = "Dar Nota";
            this.btnDarNota.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(41, 135);
            this.txtNota.MaxLength = 4;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 26);
            this.txtNota.TabIndex = 10;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Location = new System.Drawing.Point(195, 83);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(121, 28);
            this.cbDisciplinas.TabIndex = 9;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(41, 83);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(121, 28);
            this.cbAluno.TabIndex = 8;
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
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.tcMain);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.tcMain.ResumeLayout(false);
            this.tpDarNotas.ResumeLayout(false);
            this.tpDarNotas.PerformLayout();
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
    }
}