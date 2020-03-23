using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LgProgramaDeEstagio2020.Relatorios
{
    public abstract class Relatorio<TipoRelatorio>
    {
        public abstract List<TipoRelatorio> BuscarDados();

        public void ExibirRelatorio()
        {
            BuscarDados().ForEach(EscrevaLinha);
        }

       // public abstract int Comparador(TipoRelatorio x, TipoRelatorio y);
        public IComparer<TipoRelatorio> Comparador { get; set; }
         private void EscrevaLinha(TipoRelatorio obj)
        {
            Console.WriteLine(obj);
        }
    }
}
