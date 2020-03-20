using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
     public class CalculoSalarioIntermitente : ICalculoFolhaDePagamento<Intermitente>
    {
        public double CalcularFolha(Intermitente funcionario, Referencia referencia)
        {
            return ((funcionario.Salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes))
                * referencia.ObtenhaDiasUteisNoMes() + (funcionario.Salario * 0.33) / 12);
        }
    }
}
