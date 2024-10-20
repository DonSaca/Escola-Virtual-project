﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        //Metodos
        private void LoadTurmasToLbTurmas ()
        {
            // Limpar a listbox pra n haver duplicados
            lbTurmas.Items.Clear();

            // Dar um loop pelos objectos em ListaTurmas
            foreach (var turma in Generic.ListaTurmas)
            {

                string turmaInfo = $"{turma.Ano}ºAno {turma.Nome}";


                lbTurmas.Items.Add(turmaInfo);
            }
        }
        private void LoadProfessoresToLbProfessores()
        {
            // Limpar a listbox pra n haver duplicados
            lbProfessoresProfessor.Items.Clear();

            // Dar um loop pelos objectos em Listaprofessores
            foreach (var professor in Generic.ListaProfessores)
            {

                string professorInfo = $"{professor.Nome}-  {professor.Turma}";


                lbProfessoresProfessor.Items.Add(professorInfo);
            }
        }

        private void LoadAlunosToLbAlunosInAluno()
        {
            // Limpar a listbox pra n haver duplicados
            lbProfessoresProfessor.Items.Clear();

            // Dar um loop pelos objectos em ListaTurmas
            foreach (var aluno in Generic.ListaAlunos)
            {

                string alunoInfo = $"{aluno.Nome}-  {aluno.NumAluno}";


                lbAlunosAluno.Items.Add(alunoInfo);
            }
        }

        private void UpdateComboboxes()
        {
            cbTurmasProfessor.DataSource = null;  // Clear the existing binding
            cbTurmasProfessor.DataSource = Generic.ListaTurmas;  // Rebind the updated list
            cbTurmasProfessor.DisplayMember = "DisplayText";
            cbTurmasAluno.DataSource = null;
            cbTurmasAluno.DataSource= Generic.ListaTurmas;
            cbTurmasAluno.DisplayMember = "DisplayText";
        }

        public void CriarAsDisciplinas()
        {
            try
            {


                Generic.admin.CriarDisciplina("MATEMATICA", "MAT", 40);
                Generic.admin.CriarDisciplina("INGLÊS", "ING", 40);
                Generic.admin.CriarDisciplina("BIOLOGIA", "BIO", 40);
                Generic.admin.CriarDisciplina("FISICA", "FIS", 40);
                Generic.admin.CriarDisciplina("HISTORIA", "HIS", 40);
                Generic.admin.CriarDisciplina("MUSICA", "MUS", 40);
                Generic.admin.CriarDisciplina("ED. FISICA", "EF", 40);
            }
            catch 
            { return; }
        }
        private void CriarDummyTurmas()
        {
            foreach (var ano in Generic.ListaAnos)
            {
                string TurmasA = "A";
                string TurmasB = "B";
                string TurmasC = "C";
                Generic.admin.CriarTurma(TurmasA, ano);
                Generic.admin.CriarTurma(TurmasB, ano);
                Generic.admin.CriarTurma(TurmasC, ano);

            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            cbAnos.DataSource = Generic.ListaAnos;
            cbAnos.DisplayMember = "Classe";

            cbTurmasProfessor.DataSource = Generic.ListaTurmas;
            cbTurmasProfessor.DisplayMember = "DisplayText";


           
                foreach (var request in Generic.ChangeRequests.Where(r => r.Status == "Pending"))
                {
                    var listItem = new ListViewItem(new[]
                    {
                request.Username,
                request.FieldName,
                request.CurrentValue,
                request.RequestedValue
            });

                    lvwPedidos.Items.Add(listItem);
                }
            

        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginFormInstance.Show();
            this.Hide();
        }

        private void btnCriarTurma_Click(object sender, EventArgs e)
        {
            if(cbAnos.SelectedItem == null)
            {
                MessageBox.Show("Escolha um Ano!");
                    return;
            }
            string nome = txtNomeTurma.Text;

            Ano classe =(Ano) cbAnos.SelectedItem;
            try
            {
                Generic.admin.CriarTurma(nome, classe);
                LoadTurmasToLbTurmas();
                UpdateComboboxes();

            }
            catch
            (Exception erro)
            {

                MessageBox.Show(erro.Message, "Erro! Esta tuma ja existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void tpCriarTurma_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeTurma_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeTurma.Text != "")
                btnCriarTurma.Enabled = true;
            else
                btnCriarTurma.Enabled = false;
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
          
        }

        private void txtContactoProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtContactoProfessor.Text.Length >= 9)
            {
                e.Handled = true;
            }

        }

        private void txtNIFprofessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtNIFprofessor.Text.Length >= 9)
            {
                e.Handled = true;
            }

        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboboxes();

            cbAnos.DataSource = Generic.ListaAnos;
            cbAnos.DisplayMember = "Classe";

            cbTurmasProfessor.DataSource = Generic.ListaTurmas;
            cbTurmasProfessor.DisplayMember = "DisplayText";



            foreach (var request in Generic.ChangeRequests.Where(r => r.Status == "Pending"))
            {
                var listItem = new ListViewItem(new[]
                {
                request.Username,
                request.FieldName,
                request.CurrentValue,
                request.RequestedValue
            });

                lvwPedidos.Items.Add(listItem);
            }


        }

        private void cbTurmasAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCriarAluno.Enabled = true;
        }

        private void cbTurmasProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCriarProfessor.Enabled = true;
        }

        private void btnCriarProfessor_Click(object sender, EventArgs e)
        {
            if (cbTurmasProfessor.SelectedItem == null)
            {
                MessageBox.Show("Escolha uma turma!");
                return;
            }
            //nome contacto numerofuncio nif user password turma

            string nome = txtNomeProfessor.Text;
            string contacto = txtContactoProfessor.Text;
            string numfunc = txtNumFunc.Text;
            string nif = txtNIFprofessor.Text;
            string password = txtPasswordProfessor.Text;
            string user = txtUserProfessor.Text;

            Turma turma = (Turma)cbTurmasProfessor.SelectedItem;
            try
            {
                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("Campo nome vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(numfunc))
                {
                    MessageBox.Show("Campo Numero de funcionario vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Campo user vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Campo password vazio!");
                    return;
                }
                Generic.admin.CriarProfessor(nome, nif, user, password, numfunc, turma);
                LoadProfessoresToLbProfessores();


            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro! Professor ja existe, provavelmente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCriarAluno_Click(object sender, EventArgs e)
        {
            if (cbTurmasAluno.SelectedItem == null)
            {
                MessageBox.Show("Escolha uma turma!");
                return;
            }
            // Nome NiF user Password numaluno Contacto  Turma
            string nome = txtNomeAluno.Text;
            string nif = txtNIfAluno.Text;
            string user = txtUserAluno.Text;
            string password = txtPasswordAluno.Text;
            string numaluno = txtNumAluno.Text;
            string contacto = txtContactoAluno.Text;
            Turma turma = (Turma)cbTurmasAluno.SelectedItem;

            try
            {

                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("Campo nome vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(numaluno))
                {
                    MessageBox.Show("Campo Numero de aluno vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Campo user vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Campo password vazio!");
                    return;
                }
                Generic.admin.CriarAluno(nome, nif, user, password, numaluno, turma);
                LoadAlunosToLbAlunosInAluno();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro! Aluno ja existe, provavelmente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNIfAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtNIfAluno.Text.Length >= 9)
            {
                e.Handled = true;
            }
        }

        private void txtContactoAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtContactoAluno.Text.Length >= 9)
            {
                e.Handled = true;
            }
        }

        private void txtNumFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if (lvwPedidos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwPedidos.SelectedItems[0];
                string username = selectedItem.SubItems[0].Text;
                string fieldName = selectedItem.SubItems[1].Text;
                string requestedValue = selectedItem.SubItems[3].Text;

                var aluno = Generic.ListaAlunos.FirstOrDefault(a => a.User == username);
                if (aluno != null)
                {
                    // Update the field based on the approved request
                    switch (fieldName)
                    {
                        case "Contacto":
                            aluno.Contacto = requestedValue;
                            break;
                        case "Morada":
                            aluno.Morada = requestedValue;
                            break;
                        case "Password":
                            aluno.Password = requestedValue;
                            break;
                    }

                    // Update the request status
                    var request = Generic.ChangeRequests.First(r => r.FieldName == fieldName && r.RequestedValue == requestedValue);
                    request.Status = "Approved";

                    MessageBox.Show("Alteraçao aprovada.");
                }
            }
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {

            if (lvwPedidos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwPedidos.SelectedItems[0];
                string username = selectedItem.SubItems[0].Text;
                string fieldName = selectedItem.SubItems[1].Text;
                string requestedValue = selectedItem.SubItems[3].Text;

                var aluno = Generic.ListaAlunos.FirstOrDefault(a => a.User == username);
                if (aluno != null)
                {
                    // Update the request status to rejected
                    var request = Generic.ChangeRequests.First(r => r.FieldName == fieldName && r.RequestedValue == requestedValue);
                    request.Status = "Rejected";

                    MessageBox.Show("Change rejected.");
                }
            }
        }

        private void lbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var turma = (Turma)lbTurmas.SelectedItem;
            var Professores = turma.Professores;
            var Alunos = turma.Alunos;

            foreach( var aluno in Alunos )
            {

            }
        }
    }
    
}
