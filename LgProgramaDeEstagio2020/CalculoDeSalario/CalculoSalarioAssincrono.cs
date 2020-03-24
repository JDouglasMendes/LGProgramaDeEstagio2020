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

        }

        private int TamanhoDoBloco()
        {
            return (_listaDeFuncionarios.Count/ProcessadoresDaMaquina()) + 1;
        }

        private List<Funcionario> FuncionariosParaProcessamento(int posicaoInicial, int posicaoFinal)
        {
            return _listaDeFuncionarios.GetRange(posicaoInicial, posicaoFinal - posicaoInicial);
        }

        private void CalculeSalarioFuncionarios(List<Funcionario> listaDeFuncionarios)
        {
            listaDeFuncionarios.ForEach(x => {
                FabricaCalculoDeSalarioDeFuncionario<Autonomo>.Singleton.Crie().CalcularFolha(x, referencia);
            
            })
        }
    }
}
