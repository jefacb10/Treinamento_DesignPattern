using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class IHIT : TemplateImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return VerificaMesmoNome(orcamento);
        }

        private bool VerificaMesmoNome(Orcamento orcamento)
        {

            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }
            return false;
            
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.0;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}
