using LgProgramaDeEstagio2020.Contratos;
using System;

namespace LgProgramaDeEstagio2020
{
    public class ObrigatorioAttribute : Attribute, IValidacaoAtributos
    {
        public string Mensagem { get; }
        public ObrigatorioAttribute(string v)
        {
            Mensagem = v;
        }

        public bool Validacao(object valor)
        {
            return valor != null;
        }
    }
}