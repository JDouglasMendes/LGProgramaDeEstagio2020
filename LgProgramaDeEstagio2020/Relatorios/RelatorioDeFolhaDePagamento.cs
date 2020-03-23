using LgProgramaDeEstagio2020.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class RelatorioDeFolhaDePagamento : Relatorio<DadosRelatorioDeFolhaDePagamento>
    {
        public override List<DadosRelatorioDeFolhaDePagamento> BuscarDados()
        {
            var listaDeTabelasDeFuncionarios = BancoDeDadosEmMemoria<TabelaDeFuncionarios>.Singleton.Select();
            var listaDeTabelasValoresCalculados = BancoDeDadosEmMemoria<TabelaValoresCalculados>.Singleton.Select();

            var listaDeDadosDaFolha = new List<DadosRelatorioDeFolhaDePagamento>();
            foreach (var linha in listaDeTabelasValoresCalculados)
            {
                listaDeDadosDaFolha.Add(new DadosRelatorioDeFolhaDePagamento(linha.TransformeEmTabela().Matricula,
                    listaDeTabelasDeFuncionarios.First(x => x.TransformeEmTabela().Matricula == linha.TransformeEmTabela().Matricula).TransformeEmTabela().Nome,
                    linha.TransformeEmTabela().Valor));

            }
            return listaDeDadosDaFolha.OrderBy(x => x.Matricula).ToList();
        }

    }
}
