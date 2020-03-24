using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Contratos
{
    public interface IValidacaoAtributos
    {
        string Mensagem { get; }
        bool Validacao(object obj);
    }
}
