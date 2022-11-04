using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;

namespace CheckDescompassoAps
{
    public partial class Consulta
    {
        public List<DataTable> ListaTabelas { get; set; }
        public List<string> Bancos { get; set; }
        public List<Cliente> ListaClientes { get; set; }
        public Consulta()
        {
            ListaTabelas = new List<DataTable>();
            Bancos = new List<string>();
            ListaClientes = new List<Cliente>();
        }
        public void FormatarArquivo(List<Arquivo> arquivos)
        {
            var caminho = $"{Directory.GetCurrentDirectory()}\\Comparativo_{DateTime.Now:yyyyMMdd_HH-mm-ss}.csv";
            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.Write($"InstanciasApServer - geradas em {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                foreach (var arquivo in RetornaDescompasso(arquivos))
                {
                    sw.WriteLine($"\n\n{arquivo.Cliente.NomeCliente}");
                    sw.WriteLine($"Build; Instancia; Porta; Server; Principal");
                    foreach (var linha in arquivo.Detalhes)
                    {
                        sw.WriteLine($"{linha}");
                    }
                    sw.Flush();
                }
            }
        }
        public List<Arquivo> RetornaDescompasso(List<Arquivo> listaArquivos)
        {
            List<Arquivo> descompassados = new List<Arquivo>();
            foreach (var arquivo in listaArquivos)
            {
                foreach (var instancia in arquivo.Instancias)
                {
                    if(instancia != arquivo.Instancias.ToArray()[0])
                    {
                        descompassados.Add(arquivo);
                        break;
                    }
                }
            }
            return descompassados;
        }
    } 
}
