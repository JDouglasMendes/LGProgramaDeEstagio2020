using LgProgramaDeEstagio2020.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Fabricas
{
    public class FabricaDeRelatorios<TTipoRelatorio>
    {
        private Dictionary<string, Relatorio<TTipoRelatorio>> dicionarioDeRelatorios;

        private FabricaDeRelatorios()
        {
            dicionarioDeRelatorios = new Dictionary<string, Relatorio<TTipoRelatorio>>()
            {
                {"LgProgramaDeEstagio2020.Relatorios.RelatorioDeAdmissoes",  new RelatorioDeAdmissoes() as Relatorio<TTipoRelatorio>},
                {"LgProgramaDeEstagio2020.Relatorios.RelatorioDeFolhaDePagamento",  new RelatorioDeFolhaDePagamento() as Relatorio<TTipoRelatorio>}
            };
        }

        public Relatorio<TTipoRelatorio> Crie()
        {
            return dicionarioDeRelatorios[(typeof(TTipoRelatorio).FullName)];
        }

        // singleton

        private static volatile FabricaDeRelatorios<TTipoRelatorio> instance;
        private static object syncRoot = new Object();

        public static FabricaDeRelatorios<TTipoRelatorio> Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FabricaDeRelatorios<TTipoRelatorio>();
                    }
                }

                return instance;
            }
        }
    }
}
