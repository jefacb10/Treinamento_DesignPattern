using System;
using System.IO;

namespace TreinamentoDesignPattern_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            IImposto icms = new ICMS();
            IImposto iss = new ISS();
            IImposto ipva = new IPVA();


            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.CalcularDeImpostos(orcamento, icms);
            calculador.CalcularDeImpostos(orcamento, iss);
            calculador.CalcularDeImpostos(orcamento, ipva);

            Console.WriteLine("Fim!");
            #endregion
            #region Chains of Responsability
            orcamento.AdicionaItem(new Item("CANETA", 10.0));
            orcamento.AdicionaItem(new Item("LAPIS", 5.0));
            orcamento.AdicionaItem(new Item("Caderno", 30.0));
            orcamento.AdicionaItem(new Item("Estojo", 3.0));
            //orcamento.AdicionaItem(new Item("Mochila", 60.0));
            //orcamento.AdicionaItem(new Item("Borracha", 50.0));
            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

            Console.WriteLine("\nValor descontado: " + calculadorDeDescontos.Calcula(orcamento));
            #endregion
            #region Decorator
            Imposto impostos = new IPTU(new IMVC());

            Orcamento orcamento2 = new Orcamento(200.0);

            Console.WriteLine("\nImpostos somados: "+ impostos.Calcula(orcamento2));
            #endregion
        }
    }
}
