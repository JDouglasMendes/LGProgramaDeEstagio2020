using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Prolabore("000","Celso", 1520.21, DateTime.Now, "Programador");
            var funcionario2 = new Clt("001", "Douglas", 30000.50, new DateTime(2020,01,1), "Gerente");
            var funcionario3 = new Autonomo("002", "Celso", 1050, new DateTime(2020, 02, 10), "Estagiario");

            funcionario.AdicioneDiasTrabalhados(new DiasTrabalhadosNoMes(new DateTime(2020, 02, 1), new DateTime(2020, 02, 15)));
            funcionario2.AdicioneDiasAfastados(new Afastamento(new DateTime(2020, 01, 1), new DateTime(2020, 01, 30)));
            funcionario3.AdicioneDiasTrabalhados(new DiasTrabalhadosNoMes(new DateTime(2020, 02, 11), new DateTime(2020, 02, 25)));


            var cadastro = new Cadastro.CadastroDeFuncionarios();
            cadastro.CadastrarFuncionario(funcionario, BancoDeDados.EnumTipoFuncionario.Prolabore);

            cadastro.CadastrarFuncionario(funcionario2, BancoDeDados.EnumTipoFuncionario.CLT);

            cadastro.CadastrarFuncionario(funcionario3, BancoDeDados.EnumTipoFuncionario.Autonomo);


            var relatorio = new Relatorios.RelatorioDeAdmissoes();
            relatorio.Comparador = new Relatorios.OrdenacaoRelatorioAdmissao(true);
            relatorio.ExibirRelatorio();

            FabricaCalculoDeSalarioDeFuncionario.Singleton.Crie(funcionario.GetType()).CalcularFolha(funcionario, new Referencia(02,2020));
            FabricaCalculoDeSalarioDeFuncionario.Singleton.Crie(funcionario2.GetType()).CalcularFolha(funcionario2, new Referencia(01, 2020));
            FabricaCalculoDeSalarioDeFuncionario.Singleton.Crie(funcionario3.GetType()).CalcularFolha(funcionario3, new Referencia(02, 2020));

            var relatorio2 = new Relatorios.RelatorioDeFolhaDePagamento();
            relatorio2.ExibirRelatorio();
            Fabricas.FabricaDeRelatorios<Relatorios.RelatorioDeFolhaDePagamento>.Singleton.Crie().ExibirRelatorio();
            Fabricas.FabricaDeRelatorios<Relatorios.RelatorioDeFolhaDePagamento>.Singleton.Crie().ExibirRelatorio();
            Fabricas.FabricaDeRelatorios<Relatorios.RelatorioDeAdmissoes>.Singleton.Crie().ExibirRelatorio();

            Console.Read();

            


        }
    }
}
