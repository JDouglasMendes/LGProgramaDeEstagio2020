using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class DadosRelatorioDeFolhaDePagamento
    {
    
        public string Matricula { get; private set;}

        public string Nome { get; private set; }

        public double Valor { get; private set; }

        public DadosRelatorioDeFolhaDePagamento(string matricula, string nome, double valor)
        {
            Matricula = matricula;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"Matricula: {Matricula} Nome: {Nome} Valor: {Valor.ToString()}";
        }


    }
}
