using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
    public class Ano
    {
        public int Classe { set; get; }
        public List<Turma> Turmas = new List<Turma>();

        public Ano (int classe)
        {
            this.Classe = classe;
        }

        public override string ToString()
        {
            // This will be displayed in the ComboBox
            return Classe.ToString();
        }


    }
}
