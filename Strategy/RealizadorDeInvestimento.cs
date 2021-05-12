using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public sealed class RealizadorDeInvestimento
    {
        public double RealizaInvestimento(Conta conta, IInvestimento investimento, double valor)
        {
            conta.Saldo += valor * 0.75;
            return investimento.investe(conta);
        } 
    }
}
