using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public static class CalculaFolha
    {
        public static double CalcularFolha(double salario, int diasTrabalhadosNoMes, Referencia referencia)
        {
            return (salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes)) * diasTrabalhadosNoMes;
        }
    }
}
