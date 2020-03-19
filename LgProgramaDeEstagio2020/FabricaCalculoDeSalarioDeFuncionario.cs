using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class FabricaCalculoDeSalarioDeFuncionario<TTipoFuncionario> where TTipoFuncionario : Funcionario
    {

        public ICalculoFolhaDePagamento<TTipoFuncionario> Crie()
        {

            switch(typeof(TTipoFuncionario).FullName)
            {
                case "LgProgramaDeEstagio2020.Clt":
                    return (ICalculoFolhaDePagamento<TTipoFuncionario>) new CalculoSalarioClt();
                    
                case "LgProgramaDeEstagio2020.Prolabore":
                    return (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioProlabore();

                case "LgProgramaDeEstagio2020.Autonomo":
                    return (ICalculoFolhaDePagamento<TTipoFuncionario>)new CalculoSalarioAutonomo();
                    

            }
            return null;
        }        
    }
}
