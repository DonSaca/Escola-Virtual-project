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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbTipoUser.SelectedIndex = 0;

            for (int i=1; i<10;)
            {
                Generic.admin.CriarAno(i);

                i++;
            }
            
            

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

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
