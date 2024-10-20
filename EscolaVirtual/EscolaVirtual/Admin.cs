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
        }
         
        public void CriarAluno(string nome, string NIF, string user, string password, string numAluno, Turma turma)
        {
            if(turma.Alunos.Any(a=> a.NumAluno == numAluno || a.User == user))
            {
                throw new InvalidOperationException("Aluno ja existe!");
            }
            Aluno novoAluno = new Aluno(nome, NIF, user, password, numAluno, turma.Nome);
            turma.Alunos.Add(novoAluno);
            Generic.ListaAlunos.Add(novoAluno);
        }
         
        public void CriarProfessor(string nome, string nif, string user, string password, string numFunc, Turma turma)
        {

            if (turma.Professores.Any(p => p.NumFunc == numFunc || p.User == user))
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
            Disciplina novaDisciplina = new Disciplina(nome, sigla, numAulas);
            Generic.ListaDisciplinas.Add(novaDisciplina);

        }
        

    }
}
