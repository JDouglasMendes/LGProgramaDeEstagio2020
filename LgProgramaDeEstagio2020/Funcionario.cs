using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Funcionario
    {
    
        public string Matricula { get; private set; }
        private string Nome { get; set; }
        private double Salario { get; set; }
        private DateTime DataAdmissao { get; set; }
        private string TipoFuncionario { get; set; } // Douglas disse que essa propriedade não sera necessaria
        private string Cargo { get; set; }

        public Funcionario(string matricula, string nome, double salario, DateTime dataAdmissao, string tipoFuncionario, string cargo)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            TipoFuncionario = tipoFuncionario;
            Cargo = cargo;
        }       
    }
}
