using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class CalculoDeFerias<TContratoDeFerias> where TContratoDeFerias : Funcionario, IContratoDeFerias
    {
        public double CalcularFerias(TContratoDeFerias funcionario)
        {
            return funcionario.Salario * 1.33;
        }
    }
}