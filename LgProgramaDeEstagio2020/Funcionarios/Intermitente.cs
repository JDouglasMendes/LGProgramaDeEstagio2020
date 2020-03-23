using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Intermitente : Funcionario
    {

        public Intermitente(string matricula, string nome, double salario, DateTime dataAdmissao, string cargo) 
            : base(matricula, nome, salario, dataAdmissao, cargo)
        {
        }


    }
}
