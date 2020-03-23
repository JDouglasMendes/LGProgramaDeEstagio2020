using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Clt : Funcionario, IContratoDeFerias
    {

        private List<Ferias> listaDeFerias { get; set; }
        private List<Afastamento> listaDeDiasAfastado;

        public Clt(string matricula, string nome, double salario, DateTime dataAdmissao, string cargo) : 
            base(matricula,nome,salario,dataAdmissao,cargo)
        {
             listaDeDiasAfastado = new List<Afastamento>();
        }

        

        public void AdicioneDiasAfastados(Afastamento diasAfastadosNoMes)
        {
            listaDeDiasAfastado.Add(diasAfastadosNoMes);
        }

        public void AdicionarFerias(Ferias ferias)
        {
            listaDeFerias.Add(ferias);
        }

        public int DiasAfastadosNoMes(Referencia referencia)
        {
            return listaDeDiasAfastado.Where(evento => evento.DataInicio.Month == referencia.Mes && evento.DataInicio.Year == referencia.Ano).ToList()
                .Sum(x => x.ObtenhaIntervaloDiasUteis());
        }


    }
}
