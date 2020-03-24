using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public class OrdenacaoRelatorioAdmissao : IComparer<DadosRelatorioDeAdmissao>
    {
        private int fator;
        public OrdenacaoRelatorioAdmissao(bool decrescente = false)
        {
            this.fator = 1;

            if (decrescente)
                this.fator = -1;                       
        }

        public int Compare(DadosRelatorioDeAdmissao x, DadosRelatorioDeAdmissao y)
        {
            return fator * (x.Nome.CompareTo(y.Nome) == 0 ? x.DataDeAdimissao.CompareTo(y.DataDeAdimissao) : x.Nome.CompareTo(y.Nome));
        }

    }
}
