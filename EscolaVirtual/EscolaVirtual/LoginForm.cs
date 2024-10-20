using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbTipoUser.SelectedIndex = 0;

            for (int i = 1; i < 10;)
            {
                Generic.admin.CriarAno(i);
                Generic.admin.CriarTurma("A", Generic.ListaAnos.FirstOrDefault(ano => ano.Classe == i));

                i++;
            }
           

            Generic.admin.CriarProfessor("Joao", "111111111", "user", "password", "0001", Generic.ListaTurmas.FirstOrDefault(turma => turma.Nome == "A" && turma.Ano == 5));

            Generic.admin.CriarAluno("Marcos", "111111111", "user", "password", "0001", Generic.ListaTurmas.FirstOrDefault(turma => turma.Nome == "A" && turma.Ano == 5));

            Generic.admin.CriarAluno("Pedro", "111111112", "user2", "password2", "0002", Generic.ListaTurmas.FirstOrDefault(turma => turma.Nome == "A" && turma.Ano == 5));

            Generic.admin.CriarAluno("Lucas", "111111113", "user3", "password3", "0003", Generic.ListaTurmas.FirstOrDefault(turma => turma.Nome == "A" && turma.Ano == 5));

            Generic.admin.CriarAluno("Maria", "111111114", "user4", "password4", "0004", Generic.ListaTurmas.FirstOrDefault(turma => turma.Nome == "A" && turma.Ano == 5));

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            cbTipoUser.SelectedIndex = 0;

          
        }

        private void lblTipoUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            //0 é Admin, 1 é Aluno, 2 é professor
            if(cbTipoUser.SelectedIndex==0 )
            {
               
                var account = Generic.ListaAdmins.FirstOrDefault(a => a.user == Username && a.password == Password);
                if (account != null)
                {
                    
                        AdminForm FormDeAdmin = new AdminForm();
                        FormDeAdmin.Show();
                        this.Hide();
                }
                else
                {

                    MessageBox.Show("user ou password incorrectos!");
                }

            }
            if(cbTipoUser.SelectedIndex==1 )
            {
                var account = Generic.ListaAlunos.FirstOrDefault(p => p.User == Username && p.Password == Password);
               
                if (account != null)
                {
                    Generic.CurrentAluno = account;
                    AlunoForm FormDeAluno = new AlunoForm();
                    FormDeAluno.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("user ou password incorrectos!");
                }

            }
            if(cbTipoUser.SelectedIndex==2 )
            {
                var account = Generic.ListaProfessores.FirstOrDefault(p => p.User == Username && p.Password == Password);
                if (account != null)
                {
                    Generic.CurrentProfessor = account;
                    ProfessorForm FormDeProfessor = new ProfessorForm();
                    FormDeProfessor.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("user ou password incorrectos!");
                }
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
