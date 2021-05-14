using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }
    }
}
