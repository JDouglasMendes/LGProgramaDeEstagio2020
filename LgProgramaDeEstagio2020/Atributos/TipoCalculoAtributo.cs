using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Atributos
{
    public class TipoCalculoAtributo : Attribute
    {
        public EnumTipoCalculado TipoCalculo { get; }

        public TipoCalculoAtributo(EnumTipoCalculado tipoCalculado) => TipoCalculo = tipoCalculado;
       
    }
}
