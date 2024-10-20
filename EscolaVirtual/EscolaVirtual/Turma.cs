using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
   public class Turma
    {
        public string Nome { set; get; }
        public int Ano { set; get; }
        public List<Disciplina> disciplinas = new List<Disciplina>();
        public List<Aluno> Alunos = new List<Aluno>();
        public List<Professor> Professores = new List<Professor>();
        public string DisplayText
        {
            get
            {
                return $"{Ano}º - {Nome}";
            }
           
        }
        

        public Turma(string nome, int ano)
        {
            this.Nome = nome;
            this.Ano = ano;
        }
    }
}
