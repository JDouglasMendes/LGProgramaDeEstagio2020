using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    class CalculoSalarioIntermitente : ICalculoFolhaDePagamento<Intermitente>
    {
        double ICalculoFolhaDePagamento<Intermitente>.CalcularFolha(Intermitente funcionario, Referencia referencia)
        {
            return ((funcionario.Salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes))
                * referencia.ObtenhaDiasUteisNoMes() + (funcionario.Salario * 0.33) / 12);
        }
    }
}
