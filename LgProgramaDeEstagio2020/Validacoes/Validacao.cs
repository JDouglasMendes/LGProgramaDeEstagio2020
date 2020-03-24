using LgProgramaDeEstagio2020.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Validacoes
{
    public class Validacao
    {
        public List<string> Valide(object obj)
        {
            var listaDeValidacao = new List<string>();

            obj.GetType().GetProperties().ToList().ForEach(propriedade => {
                propriedade.GetCustomAttributes(false).ToList().Where(atributo => atributo.GetType() == typeof(IValidacaoAtributos)).ToList().
                ForEach(validacao => {
                    if (((IValidacaoAtributos)validacao).Validacao(propriedade.GetValue(obj, null)))
                    {
                        listaDeValidacao.Add(((IValidacaoAtributos)validacao).Mensagem);
                    };
                });
            });

            return listaDeValidacao;
        }
    }
}
