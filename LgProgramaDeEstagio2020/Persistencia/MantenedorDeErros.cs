using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LgProgramaDeEstagio2020.Persistencia
{
    public class MantenedorDeErros
    {
        public void GravarErros(List<string> listaErros){
            var info = Path.Combine((new FileInfo(Assembly.GetExecutingAssembly().Location)).FullName, "\\Erros.txt");

            if (! File.Exists(info))        
                File.Create(info);

            using (var arquivo = new StreamWriter(info, true))
            {
                listaErros.ForEach(arquivo.WriteLine);
            }
        }
    }
}
