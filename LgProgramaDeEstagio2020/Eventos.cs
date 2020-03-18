using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    //SERVE PARA LANÇAR EVENTOS RELACIONADOS A FÉRIAS E AFASTAMENTO
    public struct Eventos
    {
        public string TipoEvento { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }

        public Eventos(string tipoEvento, DateTime dataInicio, DateTime dataFim)
        {
            TipoEvento = tipoEvento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

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
