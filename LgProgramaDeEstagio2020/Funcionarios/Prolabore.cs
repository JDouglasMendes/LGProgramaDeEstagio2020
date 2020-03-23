using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class Prolabore : Autonomo , IContratoDeFerias
    {
        private List<Ferias> listaDeFerias { get; set; }

        public Prolabore(string matricula, string nome, double salario, DateTime dataAdmissao, string cargo) 
            : base(matricula, nome, salario, dataAdmissao, cargo)
        {
           
        }
        public void AdicionarFerias(Ferias ferias)
        {
            listaDeFerias.Add(ferias);
        }

    }
}
