using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    [TipoCalculoAtributo(EnumTipoCalculado.Ferias,typeof(Funcionario))] 
    public class CalculoDeFerias<TContratoDeFerias> where TContratoDeFerias : Funcionario, IContratoDeFerias
    {
        public void CalcularFerias(TContratoDeFerias funcionario, Referencia referencia)
        {
            var valor = funcionario.Salario * 1.33;

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(funcionario, referencia, EnumTipoCalculado.Ferias, valor);
        }
    }
}