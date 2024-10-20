using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
    public class Professor
    {
        public string Nome { set; get; }
        public string Morada { set; get; }
        public string Contacto { set; get; }
        public string NIF { set; get; }
        public string User { set; get; }
        public string Password { set; get; }
        public string NumFunc { set; get; }
        public string Turma { set; get; }

        public Professor(string nome, string nif, string user, string password, string numFunc, string turma)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.User = user;
            this.Password = password;
            this.NumFunc = NumFunc;
            this.Turma = turma;

        }



    }
}
