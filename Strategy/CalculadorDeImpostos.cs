using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public sealed class CalculadorDeImpostos
    {
        public void CalcularDeImpostos(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.GetType().Name + ": " + imposto.Calcula(orcamento));
        }
    }
}
