using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get ; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
