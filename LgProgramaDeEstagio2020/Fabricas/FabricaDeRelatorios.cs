using LgProgramaDeEstagio2020.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Fabricas
{
    public class FabricaDeRelatorios<TTipoRelatorio>
    {
        private Dictionary<string, Object> dicionarioDeRelatorios;

        private FabricaDeRelatorios()
        {
            dicionarioDeRelatorios = new Dictionary<string, Object>()
            {
                {"LgProgramaDeEstagio2020.Relatorios.RelatorioDeAdmissoes",  new RelatorioDeAdmissoes()},
                {"LgProgramaDeEstagio2020.Relatorios.RelatorioDeFolhaDePagamento",  new RelatorioDeFolhaDePagamento()}
            };
        }

        public TTipoRelatorio Crie()
        {
            return (TTipoRelatorio)dicionarioDeRelatorios[(typeof(TTipoRelatorio).FullName)];
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
