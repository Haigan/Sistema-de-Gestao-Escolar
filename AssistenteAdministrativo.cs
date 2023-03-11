using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class AssistenteAdministrativo : Funcionario
    {
        public double AdicionalNoturno { get; set; }
        public Gerente Supervisor { get; set; }

    }
}