﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Prolabore : Autonomo
    {
        public Prolabore(string matricula, string nome, double salario, DateTime dataAdmissao, string tipoFuncionario, string cargo) 
            : base(matricula, nome, salario, dataAdmissao, tipoFuncionario, cargo)
        {
           
        }
    }
}
