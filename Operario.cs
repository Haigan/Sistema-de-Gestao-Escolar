using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Operario : Empregado
    {
        public double ValorProducao { get; set; }
        public double Comissao { get; set; }

        public override double CalcularSalario()
        {
            return base.CalcularSalario();
        }
        public Operario(double valorProducao, double comissao)
        : base(codigoSetor, salarioBase, imposto)
        {
            ValorProducao = valorProducao;
            Comissao = comissao;
        }
    }
}