using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
    public class Aluno
    {
        public string Nome { set; get; }
        public string Morada { set; get; }
        public string Contacto { set; get; }
        public string NIF { set; get; }
        public string User { set; get; }
        public string Password { set; get; }
        public string NumAluno { set; get; }
        public string Turma { set; get; }
        public List<Nota> Notas = new List<Nota>();

        public string DisplayText
        { 
            get
            {
                return $"{Nome}-{NumAluno}";
            }
        }

        //constructores
        public Aluno(string nome, string nif, string user, string password, string numAluno, string turma)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.User = user;
            this.Password = password;
            this.NumAluno = numAluno;
            this.Turma = turma;

        }
        //Metodo
        public void AdicionarNota(Nota nota)
        {
            this.Notas.Add(nota);
        }
        public void RequestChange(string fieldName, string newValue)
        {
            // Add a new change request for the field being updated
            string currentValue = GetCurrentValue(fieldName);  // Method to get the current value
            Generic.ChangeRequests.Add(new InfoChangeRequest
            {
                FieldName = fieldName,
                RequestedValue = newValue,
                CurrentValue = currentValue,
                Username = this.User,
                Status = "Pending"
            });
        }
        private string GetCurrentValue(string fieldName)
        {
            // Return the current value of the requested field
            switch (fieldName)
            {
                case "Contact":
                    return this.Contacto;
                case "Address":
                    return this.Morada;
                case "Password":
                    return this.Password;
                default:
                    return null;
            }
        }
    }
}
