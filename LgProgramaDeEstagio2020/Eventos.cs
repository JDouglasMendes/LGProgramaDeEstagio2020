using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public struct Eventos
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

        public int ObtenhaIntervaloDeDias()
        {
            return (DataFim - DataInicio).Days;
        }

        public int DiasUteis()
        {
            int ContadorDias = 0;
            for (DateTime i = DataInicio.Date; i <= DataFim.Date; i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    ContadorDias++;
                }

            }
            return ContadorDias;
        }

    }
}
