using LgProgramaDeEstagio2020.Contratos;
using System;

namespace LgProgramaDeEstagio2020
{
    public class MaiorQueZeroAttribute : Attribute, IValidacaoAtributos
    {
        public string Mensagem { get; }

        public MaiorQueZeroAttribute(string v)
        {
            this.Mensagem = v;
        }
        
        public bool Validacao(object obj)
        {
            return (double)obj < 0;
        }
    }
}