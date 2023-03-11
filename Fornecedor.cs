using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herancas1
{
    public class Fornecedor : Humanos
    {
        public double ValorCredito { get; set; }
        public double ValorDivida { get; set; }
        public double ObterSaldo()
        {
            return ValorCredito - ValorDivida;
        }
        public Fornecedor(double valorCredito, double valorDivida)
        {
            ValorCredito = valorCredito;
            ValorDivida = valorDivida;
        }
    }
}