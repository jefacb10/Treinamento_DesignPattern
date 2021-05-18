using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class NotaFiscalDAO : IAcaoAposGerarNota
    {
        public void ExecutaAcao(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Salvando nota no BD...");
        }
    }
}
