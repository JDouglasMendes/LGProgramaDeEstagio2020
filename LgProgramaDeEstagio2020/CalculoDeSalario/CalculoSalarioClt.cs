using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    [TipoCalculoAtributo(EnumTipoCalculado.Salario)]
    public class CalculoSalarioClt : ICalculoFolhaDePagamento<Clt>
    {

        public void CalcularFolha(Clt clt, Referencia referencia)
        {

            var valor =  clt.DiasAfastadosNoMes(referencia) <= 15 ? clt.Salario 
                : CalculaFolha.CalcularFolha(clt.Salario, DateTime.DaysInMonth(referencia.Ano,referencia.Mes) - (clt.DiasAfastadosNoMes(referencia) -15) ,referencia);

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(clt, referencia, EnumTipoCalculado.Salario, valor);

        }
    }
}
