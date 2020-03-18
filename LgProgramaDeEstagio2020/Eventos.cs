using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{

    public class Eventos
    {
        public string TipoDeEvento { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }

        public Eventos(string tipoDeEvento, DateTime dataInicio, DateTime dataFim)
        {
            TipoDeEvento = tipoDeEvento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }        


        //

        public int ObtenhaDiasAusentes()
        {
            return 0;
        }
    }
}
