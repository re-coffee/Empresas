using System;
using System.IO;

namespace CheckDescompassoAps
{
    class Program
    {
        static void Main(string[] args)
        {
            var processo = new Consulta();
            foreach (var arg in args)
            {
                processo.Bancos.Add(arg);
            }
            var arquivos = processo.GerarComparativo();
            processo.FormatarArquivo(arquivos);
        }
    }
}