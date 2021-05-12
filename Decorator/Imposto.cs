using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto(Imposto imposto) {
            OutroImposto = imposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);

    }
}
