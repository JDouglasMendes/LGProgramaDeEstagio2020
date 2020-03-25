using LgProgramaDeEstagio2020.Atributos;
using LgProgramaDeEstagio2020.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;



namespace LgProgramaDeEstagio2020
{
     public sealed class FabricaCalculoDeSalarioDeFuncionario
     {
        private Dictionary<string, ICalculoSalarioAssincrono> dictionaryDeCalculoDeSalario;
        
        private FabricaCalculoDeSalarioDeFuncionario()
        {
            dictionaryDeCalculoDeSalario = new Dictionary<string, ICalculoSalarioAssincrono>();

            Assembly.GetExecutingAssembly().GetTypes().ToList().ForEach(x => 
            {
                var tipoCalculo = x.GetType().GetCustomAttributes(false).ToList().Where(y => y.GetType() == typeof(TipoCalculoAtributo)).ToList().First() as TipoCalculoAtributo;

                if(tipoCalculo != null && tipoCalculo.TipoCalculo != EnumTipoCalculado.Ferias)
                {
                    dictionaryDeCalculoDeSalario.Add(tipoCalculo.TipoDeFuncionario.FullName, Activator.CreateInstance(x) as ICalculoSalarioAssincrono);
                }
            });

            //{
            //    { "LgProgramaDeEstagio2020.CalculoDeSalario.Clt", new CalculoSalarioClt()},
            //    { "LgProgramaDeEstagio2020.CalculoDeSalario.Autonomo", new CalculoSalarioAutonomo()},
            //    { "LgProgramaDeEstagio2020.CalculoDeSalario.Prolabore", new CalculoSalarioProlabore()},
            //    { "LgProgramaDeEstagio2020.CalculoDeSalario.Intermitente", new CalculoSalarioIntermitente()}
            //};
        }

        public ICalculoSalarioAssincrono Crie(Type tipo)
        {
            return dictionaryDeCalculoDeSalario[tipo.FullName];
        }

        // singleton
        private static volatile FabricaCalculoDeSalarioDeFuncionario instance;
        private static object syncRoot = new Object();

        public static FabricaCalculoDeSalarioDeFuncionario Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FabricaCalculoDeSalarioDeFuncionario();
                    }
                }

                return instance;
            }
        }


    }
    }
