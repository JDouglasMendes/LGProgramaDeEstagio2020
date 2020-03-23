using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class DadosRelatorioDeAdmissao
    {
        public string Nome { get; private set; }
        public DateTime DataDeAdimissao { get; private set; }

        public DadosRelatorioDeAdmissao(string nome, DateTime dataDeAdimissao)
        {
            Nome = nome;
            DataDeAdimissao = dataDeAdimissao;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} Data de Admissão: {DataDeAdimissao.ToShortDateString()}";
        }
    }
}
