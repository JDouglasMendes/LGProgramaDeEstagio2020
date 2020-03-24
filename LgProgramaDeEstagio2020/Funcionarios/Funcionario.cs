using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public abstract class Funcionario
    {
        [Obrigatorio("Matrícula é obrigatória.")]
        public string Matricula { get; protected set; }

        [Obrigatorio("Nome é obrigatório.")]
        [Tamanho(3,100, "O nome deve ser maior que 3 e menor que 100 caracteres.")]
        public string Nome { get; protected set; }

        [Obrigatorio("Salario é obrigatório.")]
        [MaiorQueZero("Salário deve ser maior que zero.")]
        public double Salario { get; protected set; }

        [Obrigatorio("Data de Admissão é obrigatória")]
        public DateTime DataAdmissao { get; protected set; }

        [Obrigatorio("Cargo é obrigatório.")]
        public string Cargo { get; protected set; }
       
        public Funcionario(string matricula, string nome, double salario, DateTime dataAdmissao, string cargo)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            Cargo = cargo;
        }
    }

}
