﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public interface ICalculoFolhaDePagamento<TTipoFuncionario> where TTipoFuncionario : Funcionario       
    {
        void CalcularFolha(TTipoFuncionario funcionario, Referencia referencia);       
    }
}
