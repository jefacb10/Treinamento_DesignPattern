using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura.Observer
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void ExecutaAcao(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Multiplicador: R$ "+notaFiscal.ValorBruto * Fator);
        }
    }
}
