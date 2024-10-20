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
    public partial class AlunoForm : Form
    {
        public AlunoForm()
        {
            InitializeComponent();
        }
        private void LoadInfoToListbox(ListBox listbox)
        {
            string nome = $"Nome: {Generic.CurrentAluno.Nome}"; 
          string nif= $"NIF: {Generic.CurrentAluno.NIF}";
           string turma= $"Turma: {Generic.CurrentAluno.Turma}";
         string morada= $"Morada: {Generic.CurrentAluno.Morada}"  ;
           string contacto= $"Contacto: {Generic.CurrentAluno.Contacto}";
         string numAluno=   $"Nº De Aluno:{Generic.CurrentAluno.NumAluno}";
          string user=  $"User: {Generic.CurrentAluno.User}";
           string Password=  $"Password: {Generic.CurrentAluno.Password}";
           
            listbox.Items.Add(nome);
            listbox.Items.Add(numAluno);
            listbox.Items.Add(turma);
            listbox.Items.Add(contacto);
            listbox.Items.Add(nif);
            listbox.Items.Add(morada);
            listbox.Items.Add(user);
            listbox.Items.Add(Password);

        }
        
        public void PopularlvwNotas(List<Nota> notas)
        {
            // Limpar pra n haver repetidos
            lvwNotas.Items.Clear();

            // iterar pelos obejctos na lista
            foreach (var nota in notas)
            {
                // Creiar o ListViewItem
                ListViewItem item = new ListViewItem(nota.Disciplina.Nome); 

                
                item.SubItems.Add(nota.Valor.ToString()); 
                item.SubItems.Add(nota.DataLancamento.ToShortDateString()); 

                // adicionar o item na listview
                lvwNotas.Items.Add(item);
            }
        }

        private void AlunoForm_Load(object sender, EventArgs e)
        {
            LoadInfoToListbox(lbInfo);
            PopularlvwNotas(Generic.CurrentAluno.Notas);
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loginFormInstance.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string field = cbTipo.SelectedItem.ToString();
            string newValue = txtNovaInfo.Text;
             
            Generic.CurrentAluno.RequestChange(field, newValue);

            MessageBox.Show("Pedido de Alteraçao submetido!");

        }
    }
}
