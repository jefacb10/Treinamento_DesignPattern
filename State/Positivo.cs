using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Positivo : EstadoDaConta
    {
        public void Deposita(double valor, ContaExerc conta)
        {
            if (valor <= 0) throw new Exception("Não é possível depositar esse valor");
            conta.Saldo += valor * 0.98;
        }

        public void NegativaConta(ContaExerc conta)
        {
            conta.EstadoConta = new Negativo();
        }

        public void PositivaConta(ContaExerc conta)
        {
            throw new Exception("Conta já está positiva");
        }

        public void Saca(double valor, ContaExerc conta)
        {
            if (valor <= 0) throw new Exception("Não é possível sacar esse valor");
            if (valor > conta.Saldo)
            {
                NegativaConta(conta);
            }
            conta.Saldo -= valor;
            
        }
    }
}
