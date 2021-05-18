using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class ImpressoraSender : IAcaoAposGerarNota
    {
        public void ExecutaAcao(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando nota para impressora...");
        }
    }
}
