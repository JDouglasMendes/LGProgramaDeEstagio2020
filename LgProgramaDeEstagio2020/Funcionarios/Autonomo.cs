using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Autonomo : Funcionario
    {
        private List<DiasTrabalhadosNoMes> listaDeDiasTrabalhados;
        public Autonomo(string matricula, string nome, double salario, DateTime dataAdmissao, string tipoFuncionario, string cargo) : 
            base(matricula, nome, salario, dataAdmissao, tipoFuncionario, cargo)
        {
            listaDeDiasTrabalhados = new List<DiasTrabalhadosNoMes>();
        }

        public void AdicioneDiasTrabalhados(DiasTrabalhadosNoMes diasTrabalhadosNoMes)
        {
            listaDeDiasTrabalhados.Add(diasTrabalhadosNoMes);
        }

        public int DiasTrabalhadosNoMes(Referencia referencia)
        {
            return listaDeDiasTrabalhados.Where(evento => evento.DataInicio.Month == referencia.Mes && evento.DataInicio.Year == referencia.Ano).ToList()
                .Sum(x => x.ObtenhaIntervaloDeDias());
        }
    }
}
