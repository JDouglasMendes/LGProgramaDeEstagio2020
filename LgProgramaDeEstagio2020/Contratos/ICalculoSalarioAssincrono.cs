﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Contratos
{
    public interface ICalculoSalarioAssincrono
    {
        void CalcularFolha(Funcionario funcionario, Referencia referencia);
    }
}
