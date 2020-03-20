using System;

namespace LgProgramaDeEstagio2020
{
    public class Referencia
    {
       
        public int Mes { get; private set; }
        public int Ano { get;} //É TEM A MESMA FUNÇÃO DO DE CIMA

        public Referencia(int mes, int ano)
        {
            Mes = mes;
            Ano = ano;
        }

        public int ObtenhaDiasUteisNoMes()
        {
            int ContadorDias = 0;
            for (DateTime i = new DateTime(Ano, Mes, 1); i.Day <= (DateTime.DaysInMonth(Ano, Mes)); i.AddDays(1))
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