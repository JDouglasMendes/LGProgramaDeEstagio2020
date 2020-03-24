using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public abstract class Funcionario
    {
        [Obrigatorio("Matrícula é Obrigatoria")]
        public string Matricula { get; protected set; }
        [Obrigatorio]
        [Tamanho(3,100)]
        public string Nome { get; protected set; }
        [Obrigatorio]
        [MaiorQueZero]
        public double Salario { get; protected set; }
        [Obrigatorio]
        public DateTime DataAdmissao { get; protected set; }
        [Obrigatorio]
        public string Cargo { get; protected set; }
       
        public Funcionario(string matricula, string nome, double salario, DateTime dataAdmissao, string cargo)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
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
