using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Contratos;
using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{ 
    [TipoCalculoAtributo(EnumTipoCalculado.Salario,typeof(Intermitente))]
    public class CalculoSalarioIntermitente : ICalculoFolhaDePagamento<Intermitente>, ICalculoSalarioAssincrono
    {
        public void CalcularFolha(Intermitente funcionario, Referencia referencia)
        {
            var valor = ((funcionario.Salario / DateTime.DaysInMonth(referencia.Ano, referencia.Mes))
                * referencia.ObtenhaDiasUteisNoMes() + (funcionario.Salario * 0.33) / 12);

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(funcionario, referencia, EnumTipoCalculado.Salario, valor);
        }

        public void CalcularFolha(Funcionario funcionario, Referencia referencia)
        {
            CalcularFolha((Intermitente)funcionario, referencia);
        }
    }
}
