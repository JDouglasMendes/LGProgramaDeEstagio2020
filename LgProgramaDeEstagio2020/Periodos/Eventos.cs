using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    //SERVE PARA LANÇAR EVENTOS RELACIONADOS A FÉRIAS E AFASTAMENTO
    public abstract class Eventos
    {
        [Obrigatorio("A Data de início é obrigatória.")]
        public DateTime DataInicio { get; private set; }

        [Obrigatorio("A Data final é obrigatória.")]
        public DateTime DataFim { get; private set; }

        public Eventos(DateTime dataInicio, DateTime dataFim)
        {
            DataInicio = dataInicio; // Lembrar de tratar entradas com mes de inicio diferente de mes de fim
            DataFim = dataFim;
        }

        public int ObtenhaIntervaloDeDias()
        {
            return (DataFim - DataInicio).Days;
        }

        public int ObtenhaIntervaloDiasUteis() //Para CLT
        {
            int ContadorDias = 0;
            for (DateTime i = DataInicio.Date; i <= DataFim.Date; i = i.AddDays(1))
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
