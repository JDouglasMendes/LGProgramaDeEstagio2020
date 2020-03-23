using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
   public class OrdenacaoAscendente<TipoRelatorio> : IComparer<TipoRelatorio> where TipoRelatorio : DadosRelatorioDeAdmissao
    {

        public int Compare(TipoRelatorio x, TipoRelatorio y)
        {
            return x.Nome.CompareTo(y.Nome) == 0 ? x.DataDeAdimissao.CompareTo(y.DataDeAdimissao) : x.Nome.CompareTo(y.Nome);
        }
    }
}
