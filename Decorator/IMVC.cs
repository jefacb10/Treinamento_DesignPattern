using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class IMVC : Imposto
    {
        public IMVC(Imposto outroImposto) : base(outroImposto) { }
        public IMVC() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
