using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
     public class CalculoSalarioIntermitente : ICalculoFolhaDePagamento<Intermitente>
    {
        public void CalcularFolha(Intermitente funcionario, Referencia referencia)
        {
            var valor = ((funcionario.Salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes))
                * referencia.ObtenhaDiasUteisNoMes() + (funcionario.Salario * 0.33) / 12);

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(funcionario, referencia, EnumTipoCalculado.Salario, valor);
        }
    }
}
