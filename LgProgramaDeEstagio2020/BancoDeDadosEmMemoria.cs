using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class BancoDeDadosEmMemoria<Tabela>
    {
        public TabelaValoresCalculados TabelaValoresCalculados { get; set; }
        private Dictionary<Type, List<ITabelaDeDados<Tabela>>> dictionaryDeDados;

        public BancoDeDadosEmMemoria()
        {
            dictionaryDeDados = new Dictionary<Type, List<ITabelaDeDados<Tabela>>>();
        }

        public void Inserir(ITabelaDeDados<Tabela> tabelaDeDados)
        {
            if (!dictionaryDeDados.ContainsKey(tabelaDeDados.GetType()))
                dictionaryDeDados.Add(tabelaDeDados.GetType(), new List<ITabelaDeDados<Tabela>>());

            dictionaryDeDados[tabelaDeDados.GetType()].Add(tabelaDeDados);
        }

        public void Update(ITabelaDeDados<Tabela> tabelaDeDados)
        {
            if (!dictionaryDeDados.ContainsKey(tabelaDeDados.GetType()))
                return;

            if (!dictionaryDeDados[tabelaDeDados.GetType()].Contains(tabelaDeDados))
                return;

            var index = dictionaryDeDados[tabelaDeDados.GetType()].IndexOf(tabelaDeDados);
            dictionaryDeDados[tabelaDeDados.GetType()][index] = tabelaDeDados;
        }


    }
}
