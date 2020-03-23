using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    public class TabelaValoresCalculados : ITabelaDeDados<TabelaValoresCalculados>
    {
        public string Matricula { get; private set; }
        public EnumTipoCalculado TipoCalculado { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }
        public double Valor { get; private set; }

        public TabelaValoresCalculados(string matricula, EnumTipoCalculado tipoCalculado, int mes, int ano, double valor)
        {
            Matricula = matricula;
            TipoCalculado = tipoCalculado;
            Mes = mes;
            Ano = ano;
            Valor = valor;
        }

        public bool Equals(TabelaValoresCalculados other)
        {
            if (Matricula == other.Matricula && Mes == other.Mes && Ano == other.Ano && TipoCalculado == other.TipoCalculado)
                return true;

            return false;
        }

        public TabelaValoresCalculados TransformeEmTabela()
        {
            return this;
        }
    }
}
