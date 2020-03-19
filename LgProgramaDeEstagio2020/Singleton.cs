using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public sealed class Singleton<TTipoFuncionario> where TTipoFuncionario : Funcionario
    {
        private static volatile Singleton instance;
        private static FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> syncRoot = new FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario>();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}
