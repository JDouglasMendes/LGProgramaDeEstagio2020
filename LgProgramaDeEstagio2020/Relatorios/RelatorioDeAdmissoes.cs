using LgProgramaDeEstagio2020.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class RelatorioDeAdmissoes
    {
        private List<DadosRelatorioDeAdmissao> BuscarDados(){
            var listaDeTabelasDeFuncionarios = BancoDeDadosEmMemoria<TabelaDeFuncionarios>.Singleton.Select();

            List<DadosRelatorioDeAdmissao> listaDeDadosDeAdmissao = new List<DadosRelatorioDeAdmissao>();
            foreach (var linha in listaDeTabelasDeFuncionarios)
            {
                listaDeDadosDeAdmissao.Add(new DadosRelatorioDeAdmissao(linha.TransformeEmTabela().Nome, linha.TransformeEmTabela().DataAdmissao));
            }
            return listaDeDadosDeAdmissao.OrderBy(x => x.Nome).ThenBy(x => x.DataDeAdimissao).ToList();
        }

        public void ExibirRelatorioDeAdmissoes()
        {          
            BuscarDados().ForEach(EscrevaLinha);
        }    

        private void EscrevaLinha(DadosRelatorioDeAdmissao obj)
        {
            Console.WriteLine(obj);
        }
    }
}
