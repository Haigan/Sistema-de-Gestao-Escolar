using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public double Codigo { get; set; }
        public string Periodo { get; set; }

        public Disciplina(string nome, double codigo, string periodo)
        {
            Nome = nome;
            Codigo = codigo;
            Periodo = periodo;
        }
    }
}