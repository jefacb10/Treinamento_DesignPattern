using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorDezPorcento();
            IDesconto d2 = new DescontoPorSetePorcento();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;
            return d1.Desconta(orcamento);
        }

    }
}
