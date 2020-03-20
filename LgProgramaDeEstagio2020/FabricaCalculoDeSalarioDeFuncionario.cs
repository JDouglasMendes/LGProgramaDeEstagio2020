﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LgProgramaDeEstagio2020
{
     public sealed class FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> where TTipoFuncionario : Funcionario
     {

        private Dictionary<string, ICalculoFolhaDePagamento<TTipoFuncionario>> dictionaryDeCalculoDeSalario;
        
        private FabricaCalculoDeSalarioDeFuncionario()
        {
            dictionaryDeCalculoDeSalario = new Dictionary<string, ICalculoFolhaDePagamento<TTipoFuncionario>>() {
                { "LgProgramaDeEstagio2020.Clt", (ICalculoFolhaDePagamento<TTipoFuncionario>) new CalculoSalarioClt()  },
                { "LgProgramaDeEstagio2020.Autonomo", (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioAutonomo()},
                { "LgProgramaDeEstagio2020.Prolabore", (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioProlabore()}
            };

        }

        public ICalculoFolhaDePagamento<TTipoFuncionario> Crie()
        {       
            return dictionaryDeCalculoDeSalario[(typeof(TTipoFuncionario).FullName)];
        }


        // singleton

        private static volatile FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> instance;
        private static object syncRoot = new Object();

        public static FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario>();
                    }
                }

                return instance;
            }
        }


    }
    }
