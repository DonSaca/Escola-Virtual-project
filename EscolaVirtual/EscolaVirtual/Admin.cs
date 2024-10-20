using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
   public  class Admin
    {
       public  string user { set; get; }
      public  string password { set; get; }
        //Constructor
        public Admin ()
        {

        }
        public Admin (string user, string password)
        {
            this.user = user;
            this.password = password;
            Generic.ListaAdmins.Add(this);
        }

        //Metodos
        public void CriarTurma (string nome, Ano ano)
        {
            if (ano.Turmas.Any(t => t.Nome == nome))
            {
                throw new InvalidOperationException("Turma ja existe!");
            }
            Turma novaTurma = new Turma(nome, ano.Classe);
            ano.Turmas.Add(novaTurma);
            Generic.ListaTurmas.Add(novaTurma);
            novaTurma.Disciplinas = Generic.ListaDisciplinas;
        }
         
        public void CriarAluno(string nome, string NIF, string user, string password, string numAluno, Turma turma)
        {
            if(turma.Alunos.Any(a=> a.NumAluno == numAluno || a.User == user || a.NIF == NIF))
            {
                throw new InvalidOperationException("Aluno ja existe!");
            }
            Aluno novoAluno = new Aluno(nome, NIF, user, password, numAluno, turma.Nome);
            turma.Alunos.Add(novoAluno);
            Generic.ListaAlunos.Add(novoAluno);
        }
         
        public void CriarProfessor(string nome, string nif, string user, string password, string numFunc, Turma turma)
        {

            if (turma.Professores.Any(p => p.NumFunc == numFunc || p.User == user || p.NIF == nif))
            {
                throw new InvalidOperationException("Professor ja existe!");
            }
                                                                                         
            Professor novoProfessor = new Professor(nome, nif, user, password, numFunc, $"{turma.Ano}º - {turma.Nome}");
            turma.Professores.Add(novoProfessor);
            Generic.ListaProfessores.Add(novoProfessor);

        }

        public void CriarAno(int classe)
        {
            Ano novoAno = new Ano(classe);
            Generic.ListaAnos.Add(novoAno);
        }

        public void CriarDisciplina(string nome, string sigla, int numAulas)
        {
            if (Generic.ListaDisciplinas.Any(d => d.Sigla == sigla))
            {
                throw new InvalidOperationException("Disciplina ja existe!");
            }
            Disciplina novaDisciplina = new Disciplina(nome, sigla, numAulas);
            Generic.ListaDisciplinas.Add(novaDisciplina);

        }

        public void ReviewChangeRequests(List<InfoChangeRequest> pendingRequests)
        {
            foreach (var request in pendingRequests)
            {

                string pedido = $"{request.Username} quer alterar  {request.FieldName} de {request.CurrentValue} para {request.RequestedValue}";
                

                // Admin chooses to approve or reject the request
                bool approve = GetAdminDecision();  // Method to get admin's decision (approve/reject)

                if (approve)
                {
                    request.IsApproved = true;
                    
                    // Apply the change to the user
                    ApplyChange(request);
                }
                else
                {
                    request.IsRejected = true;
                  
                }
            }
        }

        private bool GetAdminDecision()
        {
            // Here you can implement the logic to let the admin approve or reject (UI decision)
            // For now, assume it's approved (true/false)
            return true;  // Example approval for simplicity
        }

        private void ApplyChange(InfoChangeRequest request)
        {
            // Apply the change based on the approved request
            var user = Generic.ListaAlunos.FirstOrDefault(u => u.User == request.Username);
            if (user != null)
            {
                switch (request.FieldName)
                {
                    case "Contacto":
                        user.Contacto = request.RequestedValue;
                        break;
                    case "Morada":
                        user.Morada = request.RequestedValue;
                        break;
                    case "Password":
                        user.Password = request.RequestedValue;
                        break;
                }
            }
        }


    }
}
