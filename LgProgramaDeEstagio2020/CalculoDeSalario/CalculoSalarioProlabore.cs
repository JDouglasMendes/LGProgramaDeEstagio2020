﻿using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    [TipoCalculoAtributo(EnumTipoCalculado.Salario)]
    public class CalculoSalarioProlabore : ICalculoFolhaDePagamento<Prolabore>
    {
        public void CalcularFolha(Prolabore prolabore, Referencia referencia)
        {
            var valor =  CalculaFolha.CalcularFolha(prolabore.Salario, prolabore.DiasTrabalhadosNoMes(referencia), referencia);

            var repositorio = new TipoCalculoRepository();
            repositorio.Adicionar(prolabore, referencia, EnumTipoCalculado.Salario, valor);
        }
    }
}
