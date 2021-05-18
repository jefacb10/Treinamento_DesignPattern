using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
        private String Observacoes;
        private DateTime DataNotaFiscal;
        private IList<IAcaoAposGerarNota> ListaAcaoAposGerarNotas = new List<IAcaoAposGerarNota>();


        public NotaFiscalBuilder()
        {
            this.DataNotaFiscal = DateTime.Now;
        }

        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> listaAcoes)
        {
            this.DataNotaFiscal = DateTime.Now;
            this.ListaAcaoAposGerarNotas = listaAcoes;
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            this.TodosItens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String obs)
        {
            this.Observacoes = obs;
            return this;
        }
        
        public NotaFiscalBuilder NaData(DateTime data)
        {
            this.DataNotaFiscal = data;
            return this;
        }
        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, DataNotaFiscal, ValorTotal, Impostos, TodosItens, Observacoes);

            foreach(IAcaoAposGerarNota acao in ListaAcaoAposGerarNotas)
            {
                acao.ExecutaAcao(notaFiscal);
            }

            return notaFiscal;
        }

        //public void AdicionaAcao(IAcaoAposGerarNota acao)
        //{
        //    this.listaAcaoAposGerarNotas.Add(acao);
        //}
    }
}
