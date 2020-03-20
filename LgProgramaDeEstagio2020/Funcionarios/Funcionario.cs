using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public abstract class Funcionario
    {
        public string Matricula { get; protected set; }
        public string Nome { get; protected set; }
        public double Salario { get; protected set; }
        public DateTime DataAdmissao { get; protected set; }
        public string TipoFuncionario { get; protected set; } // Douglas disse que essa propriedade não sera necessaria
        public string Cargo { get; protected set; }
       
        public Funcionario(string matricula, string nome, double salario, DateTime dataAdmissao, string tipoFuncionario, string cargo)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            TipoFuncionario = tipoFuncionario;
            Cargo = cargo;
        }

        /*public int CalcularDiasAfastados(int mes, int ano)
        {
            int contadorDias = 0;
            for(int i = 0; i < Eventos.Count; i++)
            {
                if (Eventos[i].TipoEvento == "AFASTAMENTO" && Eventos[i].DataInicio.Month == mes && Eventos[i].DataInicio.Year == ano)
                    contadorDias += Eventos[i].ObtenhaIntervaloDeDias();
            }

            return Eventos
                .Where(evento => evento.TipoEvento == "AFASTAMENTO" && evento.DataInicio.Month == mes && evento.DataInicio.Year == ano).ToList()
                .Sum(x => x.ObtenhaIntervaloDeDias());

            return contadorDias;
        }*/
    }

}
