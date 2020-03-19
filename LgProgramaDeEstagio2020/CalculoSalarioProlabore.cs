using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class CalculoSalarioProlabore : ICalculoFolhaDePagamento<Prolabore>
    {
        public double CalcularFolha(Prolabore prolabore, Referencia referencia)
        {
            return CalculaFolha.CalcularFolha(prolabore.Salario, prolabore.DiasTrabalhadosNoMes(referencia), referencia);
        }
    }
}
