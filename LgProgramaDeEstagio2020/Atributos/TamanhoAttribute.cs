using LgProgramaDeEstagio2020.Contratos;
using System;

namespace LgProgramaDeEstagio2020
{
    public class TamanhoAttribute : Attribute, IValidacaoAtributos
    {
        public string Mensagem { get; }
        public int tamanhoMinimo;
        public int tamanhoMaximo;

        public TamanhoAttribute(int tamanhoMinimo, int tamanhoMaximo, string mensagem)
        {
            this.tamanhoMinimo = tamanhoMinimo;
            this.tamanhoMaximo = tamanhoMaximo;
            this.Mensagem = mensagem;
        }

        public bool Validacao(object obj)
        {
            return ((string)obj).Length > tamanhoMinimo && ((string)obj).Length <= tamanhoMaximo;
        }
    }
}