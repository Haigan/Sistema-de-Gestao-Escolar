using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class AssistenteTecnico : Funcionario
    {
        public double Bonus { get; set; }
        public Gerente Supervisor { get; set; }

    }
}