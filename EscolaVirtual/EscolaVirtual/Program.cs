using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         public static LoginForm loginFormInstance;
        [STAThread]
       
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginFormInstance = new LoginForm();
            Application.Run(loginFormInstance);

            
        }
    }
}
