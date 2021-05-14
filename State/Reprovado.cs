using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é possível aplicar desconto");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou reprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
