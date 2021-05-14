using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Negativo : EstadoDaConta
    {
        public void Deposita(double valor, ContaExerc conta)
        {
            if (valor <= 0) throw new Exception("Não é possível sacar esse valor");
            conta.Saldo += valor * 0.95;
            if (conta.Saldo >= 0)
            {
                PositivaConta(conta);
            }
            

        }

        public void NegativaConta(ContaExerc conta)
        {
            throw new Exception("Conta já está negativa");
        }

        public void PositivaConta(ContaExerc conta)
        {
            conta.EstadoConta = new Positivo();
        }

        public void Saca(double valor, ContaExerc conta)
        {
            throw new Exception("Não é possível sacar com saldo negativo");
        }
    }
}
