using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Empregado : Humanos
    {
        public string CodigoSetor { get; set; }
        public double SalarioBase { get; set; }
        public double Imposto { get; set; }

        public virtual double CalcularSalario()
        {
            return SalarioBase - Imposto;
        }
        public Empregado(string codigoSetor, double salarioBase, double imposto)
        {
            CodigoSetor = codigoSetor;
            SalarioBase = salarioBase;
            Imposto = imposto;
        }
    }
}