using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
    public class Nota
    {
        public Aluno Aluno { set; get; }
        public double Valor { set; get; }
        public Disciplina Disciplina { set; get; }
        public DateTime DataLancamento { set; get; }
    }
}
