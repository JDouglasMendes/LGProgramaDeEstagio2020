using LgProgramaDeEstagio2020.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class RelatorioDeAdmissoes : Relatorio<DadosRelatorioDeAdmissao>
    {
        public override List<DadosRelatorioDeAdmissao> BuscarDados()
        {
            var listaDeTabelasDeFuncionarios = BancoDeDadosEmMemoria<TabelaDeFuncionarios>.Singleton.Select();
            List<DadosRelatorioDeAdmissao> listaDeDadosDeAdmissao = new List<DadosRelatorioDeAdmissao>();

            foreach (var linha in listaDeTabelasDeFuncionarios)
            {
                listaDeDadosDeAdmissao.Add(new DadosRelatorioDeAdmissao(linha.TransformeEmTabela().Nome, linha.TransformeEmTabela().DataAdmissao));
            }

            listaDeDadosDeAdmissao.Sort((x, y) =>
            {
                return x.Nome.CompareTo(y.Nome) == 0 ? x.DataDeAdimissao.CompareTo(y.DataDeAdimissao) : x.Nome.CompareTo(y.Nome);
            });

            listaDeDadosDeAdmissao.Sort(Comparador);
            //Se Existe critorio de ordenação

            listaDeDadosDeAdmissao.Sort(Comparadorr);

            return listaDeDadosDeAdmissao.OrderBy(x => x.Nome).ThenBy(x => x.DataDeAdimissao).ToList();
        }

        public void ReordenarTabela()
        {

        }


    }
}
