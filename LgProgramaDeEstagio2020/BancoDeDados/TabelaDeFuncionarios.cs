using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.BancoDeDados
{
    public class TabelaDeFuncionarios : ITabelaDeDados<TabelaDeFuncionarios>
    {
        public string Matricula { get; private set; }
        public EnumTipoFuncionario TipoFuncionario { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public DateTime DataAdmissao { get; private set; }
        public string Cargo { get; private set; }

        public TabelaDeFuncionarios(string matricula, EnumTipoFuncionario tipoFuncionario, string nome, double salario, DateTime dataAdmissao, string cargo)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            Cargo = cargo;
            TipoFuncionario = tipoFuncionario;
        }

        public bool Equals(TabelaDeFuncionarios other)
        {
            if (Matricula == other.Matricula)
                return true;

            return false;
        }

        public TabelaDeFuncionarios TransformeEmTabela()
        {
            return this;
        }
    }
}
