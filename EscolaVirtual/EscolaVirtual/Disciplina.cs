using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
   public class Disciplina
    {
        public string Nome { set; get; }
        public string Sigla { set; get; }
        public int NumAulas { set; get; }

        public Disciplina (string nome, string sigla, int numAulas)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.NumAulas = numAulas;

        }

    }
}
