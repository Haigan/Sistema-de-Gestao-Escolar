using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Administrador : Empregado
    {
        public double AjudaDeCusto { get; set; }
        public override double CalcularSalario()
        {
            return base.CalcularSalario() + AjudaDeCusto;
        }
        public Administrador(double ajudaDeCusto)
        : base(codigoSetor, salarioBase, imposto)
        {
            AjudaDeCusto = ajudaDeCusto;
        }

    }
}