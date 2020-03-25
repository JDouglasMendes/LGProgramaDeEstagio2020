using LgProgramaDeEstagio2020.BancoDeDados;
using LgProgramaDeEstagio2020.Persistencia;
using LgProgramaDeEstagio2020.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Cadastro
{
    public class CadastroDeFuncionarios
    {
        public void CadastrarFuncionario(Funcionario funcionario, EnumTipoFuncionario tipoFuncionario)
        {
            try
            {
                Validacao.Valide(funcionario);
                BancoDeDadosEmMemoria<TabelaDeFuncionarios>.Singleton.Inserir(new TabelaDeFuncionarios(funcionario.Matricula, tipoFuncionario, funcionario.Nome,
                        funcionario.Salario, funcionario.DataAdmissao, funcionario.Cargo));
            }
            catch(ValidacaoException erro)
            {
                MantenedorDeErros.GravarErros(erro.ListaDeErros);
            }
        }
    }
}
