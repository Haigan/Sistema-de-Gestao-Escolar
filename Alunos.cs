using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Alunos
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public Alunos(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}