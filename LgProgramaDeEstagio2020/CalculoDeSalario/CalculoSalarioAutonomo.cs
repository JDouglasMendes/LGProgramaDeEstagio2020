using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    [TipoCalculoAtributo(EnumTipoCalculado.Salario)]
    public class CalculoSalarioAutonomo : ICalculoFolhaDePagamento<Autonomo>
    {
        public void CalcularFolha(Autonomo autonomo, Referencia referencia)
        {
            var valor = CalculaFolha.CalcularFolha(autonomo.Salario, autonomo.DiasTrabalhadosNoMes(referencia), referencia);

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(autonomo, referencia, EnumTipoCalculado.Salario, valor);
        }

    }
}
