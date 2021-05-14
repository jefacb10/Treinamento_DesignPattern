using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDesignPattern_Alura
{
    public interface EstadoDaConta
    {
        void Deposita(double valor, ContaExerc conta);

        void Saca(double valor, ContaExerc conta);

        void PositivaConta(ContaExerc conta);

        void NegativaConta(ContaExerc conta);
    }
}
