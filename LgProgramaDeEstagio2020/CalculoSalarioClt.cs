using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class CalculoSalarioClt : ICalculoFolhaDePagamento<Clt>
    {

        public double CalcularFolha(Clt clt, Referencia referencia)
        {

            return  clt.DiasAfastadosNoMes(referencia) <= 15 ? clt.Salario 
                : CalculaFolha.CalcularFolha(clt.Salario, DateTime.DaysInMonth(referencia.Ano,referencia.Mes) - (clt.DiasAfastadosNoMes(referencia) -15) ,referencia);
                


        }
    }
}
