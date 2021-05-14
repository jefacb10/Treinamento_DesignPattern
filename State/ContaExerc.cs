using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class ContaExerc
    {
        public double Saldo { get; set; } = 0.00;

        public int Agencia { get; set; }

        public int Conta { get; set; }

        public string CPF { get; set; }

        public EstadoDaConta EstadoConta { get; set; }

        public ContaExerc(int agencia, int conta, string cpf)
        {
            CPF = cpf;
            Agencia = agencia;
            Conta = conta;
            EstadoConta = new Positivo();
        }

        public void Deposita(double valor)
        {
            EstadoConta.Deposita(valor, this);
        }

        public void Saca(double valor)
        {
            EstadoConta.Saca(valor, this);
        }

        public void PositivaConta()
        {
            EstadoConta.PositivaConta(this);
        }

        public void NegativaConta()
        {
            EstadoConta.NegativaConta(this);
        }



    }

}
