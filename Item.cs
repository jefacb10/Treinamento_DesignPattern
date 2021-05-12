using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Item
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public Item(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

    }


}
