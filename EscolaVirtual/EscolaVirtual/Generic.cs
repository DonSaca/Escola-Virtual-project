using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
   public static  class Generic
    {
        public static List<Ano> ListaAnos = new List<Ano>();
        public static List<Admin>ListaAdmins = new List<Admin>();
        public static List<Aluno> ListaAlunos = new List<Aluno>();
        public static List<Professor> ListaProfessores = new List<Professor>();
        public static List<Disciplina> ListaDisciplinas = new List<Disciplina>();
        public static List<Turma> ListaTurmas = new List<Turma>();
        public static List<InfoChangeRequest> ChangeRequests { get; set; } = new List<InfoChangeRequest>();

        public static Admin admin = new Admin("admin", "admin");
        public static Professor CurrentProfessor = null;
        public static Aluno CurrentAluno = null;


    }
}
