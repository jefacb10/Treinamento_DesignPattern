using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class ItemDaNotaBuilder
    {
        public double Valor { get; private set; }
        public string Nome { get; private set; }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNotaBuilder ComNome(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public ItemDaNota CriarItem()
        {
            return new ItemDaNota(Nome, Valor);
        }
    }
}
