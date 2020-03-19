using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class CalculoSalarioAutonomo : ICalculoFolhaDePagamento<Autonomo>
    {
        public double CalcularFolha(Autonomo autonomo, Referencia referencia)
        {
            return (autonomo.Salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes)) * autonomo.DiasTrabalhadosNoMes(referencia);
        }

    }
}

