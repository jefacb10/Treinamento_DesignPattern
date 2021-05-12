using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);

        IDesconto Proximo { get; set; }
    }
}
