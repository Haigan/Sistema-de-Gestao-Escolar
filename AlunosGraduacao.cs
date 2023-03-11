using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class AlunosGraduacao : Alunos
    {
        public string CodigoGraduacao { get; set; }

        public AlunosGraduacao(string codigoGraduacao) : base(nome, matricula)
        {
            CodigoGraduacao = codigoGraduacao;
        }
    }
}