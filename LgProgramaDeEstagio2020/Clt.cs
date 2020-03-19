using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Clt : Funcionario
    {
        //private List<Ferias> listaDeFerias;
        private List<Afastamento> listaDeDiasAfastado;

        public Clt(string matricula, string nome, double salario, DateTime dataAdmissao, string tipoFuncionario, string cargo) : 
            base(matricula,nome,salario,dataAdmissao,tipoFuncionario,cargo)
        {
             listaDeDiasAfastado = new List<Afastamento>();
        }

        public void AdicioneDiasAfastados(Afastamento diasAfastadosNoMes)
        {
            listaDeDiasAfastado.Add(diasAfastadosNoMes);
        }

        public int DiasAfastadosNoMes(Referencia referencia)
        {
            return listaDeDiasAfastado.Where(evento => evento.DataInicio.Month == referencia.Mes && evento.DataInicio.Year == referencia.Ano).ToList()
                .Sum(x => x.ObtenhaIntervaloDiasUteis());
        }


    }
}
