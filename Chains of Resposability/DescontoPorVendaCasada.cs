using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get ; set ; }


        public double Desconta(Orcamento orcamento)
        {
            if(ExisteMesmoItem("CANETA", orcamento) && ExisteMesmoItem("LAPIS", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        public bool ExisteMesmoItem(String nome, Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Nome.ToUpper().Equals(nome.ToUpper()))
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
