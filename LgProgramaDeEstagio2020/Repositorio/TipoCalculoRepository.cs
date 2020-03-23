using LgProgramaDeEstagio2020.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Repositorio
{
    public class TipoCalculoRepository : ITipoCalculoRepository
    {
        public void Adicionar(Funcionario funcionario, Referencia referencia, EnumTipoCalculado enumTipoCalculado, double valor)
        {
            BancoDeDadosEmMemoria<TabelaValoresCalculados>.Singleton.Inserir
                (new TabelaValoresCalculados(funcionario.Matricula, enumTipoCalculado, referencia.Mes, referencia.Ano, valor));

        }

        public void Excluir(Funcionario funcionario, Referencia referencia, EnumTipoCalculado enumTipoCalculado)
        {
            BancoDeDadosEmMemoria<TabelaValoresCalculados>.Singleton.Delete
                (new TabelaValoresCalculados(funcionario.Matricula, enumTipoCalculado, referencia.Mes, referencia.Ano, 0));
        }
    }
}
