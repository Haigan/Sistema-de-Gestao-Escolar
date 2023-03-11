using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class AlunosPosGraduacao : Alunos
    {
        public string CodigoPosGraducao { get; set; }

        public AlunosPosGraduacao(string codigoPosGraducao) : base(nome, matricula)
        {
            CodigoPosGraducao = codigoPosGraducao;
        }
    }
}