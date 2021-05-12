using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Conservador : IInvestimento
    {
        public double investe(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
