using System;
using TreinamentoDesignPattern_Alura.Observer;
using System.IO;
using System.Collections.Generic;

namespace TreinamentoDesignPattern_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            Console.WriteLine("\n\n-----STRATEGY-----");
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
            Console.WriteLine("\n\n-----CHAINS OF RESPONSABILITY-----");
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
            Console.WriteLine("\n\n-----DECORATOR-----");
            Imposto impostos = new IPTU(new IMVC());

            Orcamento orcamento2 = new Orcamento(200.0);

            Console.WriteLine("\nImpostos somados: "+ impostos.Calcula(orcamento2));
            #endregion
            #region State
            Console.WriteLine("\n\n-----STATE-----");
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();

            Console.WriteLine("\n\nTeste Conta - Exercício:");
            ContaExerc conta = new ContaExerc(8911, 18288, "389.808.328-42");
            conta.Deposita(300.00);
            conta.Saca(400.0);
            conta.Deposita(10.00);
            Console.WriteLine("saldo da conta: " + conta.Saldo);
            Console.WriteLine("Estado da conta: " + conta.EstadoConta.GetType().Name);
            conta.Deposita(500.00);
            Console.WriteLine("saldo da conta: " + conta.Saldo);
            Console.WriteLine("Estado da conta: " + conta.EstadoConta.GetType().Name);
            #endregion
            #region Builder
            Console.WriteLine("\n\n-----BUILDER-----");
            NotaFiscal notaFiscal1 = new NotaFiscalBuilder()
                     .ParaEmpresa("Alura")
                    .ComCnpj("123.456.789/0001-10")
                    .Com(new ItemDaNotaBuilder().ComNome("item 1").ComValor(100.0).CriarItem())
                    .Com(new ItemDaNotaBuilder().ComNome("item 2").ComValor(200.0).CriarItem())
                    .Com(new ItemDaNotaBuilder().ComNome("item 3").ComValor(300.0).CriarItem())
                    .ComObservacoes("entregar nf pessoalmente")
                    .Constroi();
            
            Console.WriteLine("Valor Bruto: R$ "+notaFiscal1.ValorBruto);

            #endregion
            #region Observer
            Console.WriteLine("\n\n-----OBSERVER-----");

            IList<IAcaoAposGerarNota> acaoAposGerarNotas = new List<IAcaoAposGerarNota>();
            acaoAposGerarNotas.Add(new EmailSender());
            acaoAposGerarNotas.Add(new NotaFiscalDAO());
            acaoAposGerarNotas.Add(new ImpressoraSender());
            acaoAposGerarNotas.Add(new Multiplicador(3.00));
            NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder(acaoAposGerarNotas);
            

            NotaFiscal notaFiscal2 = notaFiscalBuilder.ParaEmpresa("Caelum")
                    .ComCnpj("113.556.606/0001-32")
                    .Com(new ItemDaNotaBuilder().ComNome("Caderno").ComValor(26.0).CriarItem())
                    .Com(new ItemDaNotaBuilder().ComNome("Lapiseira").ComValor(10.0).CriarItem())
                    .Com(new ItemDaNotaBuilder().ComNome("Estojo").ComValor(10.0).CriarItem())
                    .ComObservacoes("entregar nf pessoalmente")
                    .Constroi();

            Console.WriteLine("Valor Bruto (NF2): R$ "+notaFiscal2.ValorBruto);
            #endregion
        }
    }
}
