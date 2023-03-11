using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class AlunosEspeciais : Alunos
    {
        public string CodigoEspecial { get; set; }

        public AlunosEspeciais(string codigoEspecial) : base(nome, matricula)
        {
            CodigoEspecial = codigoEsppecial;
        }
    }
}