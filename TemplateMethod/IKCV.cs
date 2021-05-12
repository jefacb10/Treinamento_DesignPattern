using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class IKCV : TemplateImpostoCondicional
    {
        public IKCV() : base() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if(item.Valor >= 100.0) {
                    return true;
                }
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
