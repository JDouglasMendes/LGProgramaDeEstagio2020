using LgProgramaDeEstagio2020.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Validacoes
{
    public static class Validacao
    {
        public static void Valide(object obj)
        {
            var listaDeValidacao = new List<string>();

            obj.GetType().GetProperties().ToList().ForEach(propriedade => {
                propriedade.GetCustomAttributes(false).ToList().
                ForEach(validacao => {
                    var avaliacao = validacao as IValidacaoAtributos;
                    if (avaliacao != null)
                    {
                        if (!avaliacao.Validacao(propriedade.GetValue(obj, null)))
                        {
                            listaDeValidacao.Add(avaliacao.Mensagem);
                        };
                    }
                });
            });

            if (listaDeValidacao.Count() != 0)
                throw new ValidacaoException(listaDeValidacao);

        }
    }
}
