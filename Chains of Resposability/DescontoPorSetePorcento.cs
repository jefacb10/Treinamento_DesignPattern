using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class DescontoPorSetePorcento : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
