using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Validacoes
{
    public class ValidacaoException : Exception
    {
        public List<string> ListaDeErros { get; }
        public ValidacaoException(List<string> listaDeErros)
        {
            ListaDeErros = listaDeErros;
        }
    }
}
