namespace EscolaVirtual
{
    partial class AlunoForm
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
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lvwNotas = new System.Windows.Forms.ListView();
            this.lblNotas = new System.Windows.Forms.Label();
            this.Disciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lvwHistorico = new System.Windows.Forms.ListView();
            this.lblNovaInfo = new System.Windows.Forms.Label();
            this.txtNovaInfo = new System.Windows.Forms.TextBox();
            this.tcMain.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpInfo);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(3, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(962, 468);
            this.tcMain.TabIndex = 0;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.lblNotas);
            this.tpInfo.Controls.Add(this.lvwNotas);
            this.tpInfo.Controls.Add(this.lbInfo);
            this.tpInfo.Controls.Add(this.lblInfo);
            this.tpInfo.Location = new System.Drawing.Point(4, 29);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(954, 435);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info Pessoal & Notas";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbTipo);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.lblHistorico);
            this.tabPage2.Controls.Add(this.lvwHistorico);
            this.tabPage2.Controls.Add(this.lblNovaInfo);
            this.tabPage2.Controls.Add(this.txtNovaInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(150, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Informaçao Pessoal";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.HorizontalScrollbar = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(10, 39);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(294, 384);
            this.lbInfo.TabIndex = 1;
            // 
            // lvwNotas
            // 
            this.lvwNotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Disciplina,
            this.Nota,
            this.Data});
            this.lvwNotas.HideSelection = false;
            this.lvwNotas.Location = new System.Drawing.Point(350, 39);
            this.lvwNotas.Name = "lvwNotas";
            this.lvwNotas.Size = new System.Drawing.Size(598, 384);
            this.lvwNotas.TabIndex = 2;
            this.lvwNotas.UseCompatibleStateImageBehavior = false;
            this.lvwNotas.View = System.Windows.Forms.View.Details;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(346, 16);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(51, 20);
            this.lblNotas.TabIndex = 3;
            this.lblNotas.Text = "Notas";
            // 
            // Disciplina
            // 
            this.Disciplina.Text = "Disciplina";
            this.Disciplina.Width = 158;
            // 
            // Nota
            // 
            this.Nota.Text = "Nota";
            this.Nota.Width = 74;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 223;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(17, 487);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 54);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Contacto",
            "Morada",
            "Passowrd"});
            this.cbTipo.Location = new System.Drawing.Point(269, 60);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 28);
            this.cbTipo.TabIndex = 19;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(278, 259);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 51);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(469, 14);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(71, 20);
            this.lblHistorico.TabIndex = 17;
            this.lblHistorico.Text = "Historico";
            // 
            // lvwHistorico
            // 
            this.lvwHistorico.HideSelection = false;
            this.lvwHistorico.Location = new System.Drawing.Point(473, 37);
            this.lvwHistorico.Name = "lvwHistorico";
            this.lvwHistorico.Size = new System.Drawing.Size(216, 384);
            this.lvwHistorico.TabIndex = 16;
            this.lvwHistorico.UseCompatibleStateImageBehavior = false;
            // 
            // lblNovaInfo
            // 
            this.lblNovaInfo.AutoSize = true;
            this.lblNovaInfo.Location = new System.Drawing.Point(269, 180);
            this.lblNovaInfo.Name = "lblNovaInfo";
            this.lblNovaInfo.Size = new System.Drawing.Size(104, 20);
            this.lblNovaInfo.TabIndex = 15;
            this.lblNovaInfo.Text = "Novos Dados";
            // 
            // txtNovaInfo
            // 
            this.txtNovaInfo.Location = new System.Drawing.Point(269, 203);
            this.txtNovaInfo.MaxLength = 9;
            this.txtNovaInfo.Name = "txtNovaInfo";
            this.txtNovaInfo.Size = new System.Drawing.Size(167, 26);
            this.txtNovaInfo.TabIndex = 14;
            this.txtNovaInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 553);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcMain);
            this.Name = "AlunoForm";
            this.Text = "AlunoForm";
            this.Load += new System.EventHandler(this.AlunoForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.ListView lvwNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.ColumnHeader Disciplina;
        private System.Windows.Forms.ColumnHeader Nota;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.ListView lvwHistorico;
        private System.Windows.Forms.Label lblNovaInfo;
        private System.Windows.Forms.TextBox txtNovaInfo;
    }
}