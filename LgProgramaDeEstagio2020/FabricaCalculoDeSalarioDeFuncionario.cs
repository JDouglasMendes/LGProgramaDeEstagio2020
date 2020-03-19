using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LgProgramaDeEstagio2020
{
    static public class FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> where TTipoFuncionario : Funcionario
    {

        private static Dictionary<string, ICalculoFolhaDePagamento<TTipoFuncionario>> dictionaryDeCalculoDeSalario;


        
        static FabricaCalculoDeSalarioDeFuncionario()
        {
            dictionaryDeCalculoDeSalario = new Dictionary<string, ICalculoFolhaDePagamento<TTipoFuncionario>>() {
                { "LgProgramaDeEstagio2020.Clt", (ICalculoFolhaDePagamento<TTipoFuncionario>) new CalculoSalarioClt()  },
                { "LgProgramaDeEstagio2020.Autonomo", (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioAutonomo()},
                { "LgProgramaDeEstagio2020.Prolabore", (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioProlabore()}
            };

        }

        public static ICalculoFolhaDePagamento<TTipoFuncionario> Crie()
        {
       
            return dictionaryDeCalculoDeSalario[(typeof(TTipoFuncionario).FullName)];
        }


        //public ICalculoFolhaDePagamento<TTipoFuncionario> Crie()
        //{

        //    //switch(typeof(TTipoFuncionario).FullName)
        //    //{
        //    //    case "LgProgramaDeEstagio2020.Clt":
        //    //        return (ICalculoFolhaDePagamento<TTipoFuncionario>) new CalculoSalarioClt();

        //    //    case "LgProgramaDeEstagio2020.Prolabore":
        //    //        return (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioProlabore();

        //    //    case "LgProgramaDeEstagio2020.Autonomo":
        //    //        return (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioAutonomo();


        //    //}
        //}



        }
    }
