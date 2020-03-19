using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public interface ICalculoFolhaDePagamento
    {
        double CalcularFolha(Funcionario funcionario, Referencia referencia);
        

    }
}
