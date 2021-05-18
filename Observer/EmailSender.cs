using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class EmailSender : IAcaoAposGerarNota
    {
        public void ExecutaAcao(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando nota por e-mail...");
        }
    }
}
