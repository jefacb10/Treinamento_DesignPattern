using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class DescontoPorDezPorcento : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1; 
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
