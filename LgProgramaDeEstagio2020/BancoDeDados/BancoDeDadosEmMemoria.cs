using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public sealed class BancoDeDadosEmMemoria<Tabela>
    {
        private Dictionary<Type, List<ITabelaDeDados<Tabela>>> dictionaryDeDados;

        private BancoDeDadosEmMemoria()
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

        public void Delete(ITabelaDeDados<Tabela> tabelaDeDados)
        {
            if (!dictionaryDeDados.ContainsKey(tabelaDeDados.GetType()))
                return;

            if (!dictionaryDeDados[tabelaDeDados.GetType()].Contains(tabelaDeDados))
                return;

            dictionaryDeDados[tabelaDeDados.GetType()].Remove(tabelaDeDados);
        }

       

        public List<ITabelaDeDados<Tabela>> Select(Func<ITabelaDeDados<Tabela>, bool> filtro)
        {
            if (!dictionaryDeDados.ContainsKey(typeof(Tabela)))
                return null;

            return dictionaryDeDados[typeof(Tabela)].Where(filtro).ToList();
        }
        public List<ITabelaDeDados<Tabela>> Select()
        {
            if (!dictionaryDeDados.ContainsKey(typeof(Tabela)))
                return null;

            return dictionaryDeDados[typeof(Tabela)];
        }

        //Singleton
        private static volatile BancoDeDadosEmMemoria<Tabela> instance;
        private static object syncRoot = new Object();

        public static BancoDeDadosEmMemoria<Tabela> Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BancoDeDadosEmMemoria<Tabela>();
                    }
                }

                return instance;
            }
        }

        /* Select(x => ((TabelaValoresCalculados) x).Valor > 1000);
         * 
         Select(OutraFuncao);

         //as duas operaçoes acima realizam a mesma função
         private bool OutraFuncao(ITabelaDeDados<Tabela> x)  
         {
             return ((TabelaValoresCalculados)x).Valor > 1000;
         }*/
    }
}
