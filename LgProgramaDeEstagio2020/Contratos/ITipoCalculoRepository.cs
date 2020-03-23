using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Contratos
{
    public interface ITipoCalculoRepository 
    {
        void Adicionar(Funcionario funcionario, Referencia referencia, EnumTipoCalculado enumTipoCalculado, double valor);
        void Excluir(Funcionario funcionario, Referencia referencia, EnumTipoCalculado enumTipoCalculado);

    }
}
