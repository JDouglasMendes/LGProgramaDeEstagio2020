using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.CalculoDeSalario
{
    public class CalculoSalarioAssincrono
    {

        private List<Funcionario> _listaDeFuncionarios;
        private Referencia referencia;
        private int ProcessadoresDaMaquina() => System.Environment.ProcessorCount;

        public CalculoSalarioAssincrono(List<Funcionario> listaDeFuncionarios, Referencia referencia)
        {
            _listaDeFuncionarios = listaDeFuncionarios;
            this.referencia = referencia;
        }

        public void CalculeAssincrono()
        {
            var inicio = 0;
            CrieThreads().ForEach(x =>
            {
                x.Start(FuncionariosParaProcessamento(inicio));
                inicio += TamanhoDoBloco()+1;
            });
        }

        private int TamanhoDoBloco()
        {
            return (_listaDeFuncionarios.Count/ProcessadoresDaMaquina()) + 1;
        }

        private List<Funcionario> FuncionariosParaProcessamento(int posicaoInicial)
        {
            return _listaDeFuncionarios.GetRange(posicaoInicial, 
                TamanhoDoBloco() + posicaoInicial >= _listaDeFuncionarios.Count() ? _listaDeFuncionarios.Count() - posicaoInicial : TamanhoDoBloco());
        }

        private void CalculeSalarioFuncionarios(Object listaDeFuncionarios)
        {
            ((List<Funcionario>)listaDeFuncionarios).ForEach(x =>
            {
                FabricaCalculoDeSalarioDeFuncionario.Singleton.Crie(x.GetType()).CalcularFolha(x, referencia);
            });
        }

        private List<System.Threading.Thread> CrieThreads()
        {
            var listaDeThreads = new List<System.Threading.Thread>();
            for (var qntThreads = 0; qntThreads < ProcessadoresDaMaquina(); qntThreads++)
            {
                listaDeThreads.Add(new System.Threading.Thread(CalculeSalarioFuncionarios));
            }

            return listaDeThreads;
        } 
    }
}
