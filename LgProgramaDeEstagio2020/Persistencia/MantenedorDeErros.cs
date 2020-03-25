using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LgProgramaDeEstagio2020.Persistencia
{
    public static class MantenedorDeErros
    {
        public static bool GravarErros(List<string> listaErros){
            if (listaErros.Count() == 0)
                return false;
            var info = Path.Combine(Directory.GetCurrentDirectory(), "Erros.txt");

            if (! File.Exists(info))        
                File.Create(info);

            using (var arquivo = new StreamWriter(info, false))
            {
                listaErros.ForEach(arquivo.WriteLine);
            }
            return true;
        }
    }
}
