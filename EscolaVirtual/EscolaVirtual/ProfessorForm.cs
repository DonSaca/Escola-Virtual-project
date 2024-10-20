using System;
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
    public partial class ProfessorForm : Form
    {
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void LoadNotasToLbNotas(Aluno aluno)
        {
            // Limpar a listbox pra n haver duplicados
            lbNotas.Items.Clear();

            // Dar um loop pelos objectos em ListaTurmas
            foreach (var nota in aluno.Notas)
            {

                string notaInfo = $"{nota.Disciplina.Nome} - {nota.Valor} em {nota.DataLancamento}";


                lbNotas.Items.Add(notaInfo);
            }
        }

        private void btnDarNota_Click(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno)cbAluno.SelectedItem;
            Disciplina disciplina = (Disciplina) cbDisciplinas.SelectedItem;
            try
            {
                double nota = double.Parse(txtNota.Text);
                try
                {
                    
                    Generic.CurrentProfessor.LancarNota(nota,disciplina,aluno);
                    LoadNotasToLbNotas(aluno);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            (Exception erro)
            {
                MessageBox.Show(erro.Message, "erro na formatacao do campo nota, tenta com , (virgula) ou . (ponto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            var ListaAlunos = Generic.ListaTurmas
           .Where(t => t.DisplayText == Generic.CurrentProfessor.Turma)
           .Select(t => t.Alunos)
           .FirstOrDefault();

            var ListaDisciplinas = Generic.ListaTurmas
          .Where(t => t.DisplayText == Generic.CurrentProfessor.Turma)
          .Select(t => t.Disciplinas)
          .FirstOrDefault();


            cbAluno.DataSource = ListaAlunos;
            cbAluno.DisplayMember = "DisplayText";

            cbDisciplinas.DataSource = ListaDisciplinas;
            cbDisciplinas.DisplayMember = "Nome";
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void ProfessorForm_Shown(object sender, EventArgs e)
        {
           
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            if (txtNota.Text != "")
                btnDarNota.Enabled = true;
            else btnDarNota.Enabled = false;
        }

        private void cbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno)cbAluno.SelectedItem;
            LoadNotasToLbNotas(aluno);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginFormInstance.Show();
            this.Hide();
        }

        private void lblContactoAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
