using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class CalculaFolha
    {
        public double CalculeSalario(Funcionario funcionario, int mes, int ano)
        {
            //Autônomo
            //(sALARIO / dIAS DO MES) * dIAS tRABALHADOS
            if(funcionario.TipoFuncionario == "AUTONOMO" ||)
            {
                return (funcionario.Salario / DateTime.DaysInMonth(ano, mes)) * CalculeDiasTrabalhados(funcionario, mes, ano);
            }
            
            else if(funcionario.TipoFuncionario == "PROLABORE")
            {
                //PRÓ LABORE
                // (sALARIO / dIAS DO MES) * dIAS tRABALHADOS se tiver férias, 1/3 adicional no salário do funcionário.

                return 0 ;
            }


        }

        public int CalculeDiasTrabalhados(Funcionario funcionario, int mes, int ano)
        {
            return funcionario.Eventos
                .Where(evento => evento.TipoEvento == "AUTONOMO" && evento.DataInicio.Month == mes && evento.DataInicio.Year == ano).ToList()
                .Sum(x => x.ObtenhaIntervaloDeDias());
        }
    }
}
