using System;
using System.Collections.Generic;
using System.Text;

namespace CheckDescompassoAps
{
    public class Arquivo
    {
        public Cliente Cliente { get; set; }
        public string StringConexao { get; set; }
        public List<string> Instancias { get; set; }
        public List<string> Detalhes { get; set; }
        public Arquivo(Cliente cliente, string stringConexao)
        {
            Cliente = cliente;
            StringConexao = stringConexao;
            Instancias = new List<string>();
            Detalhes = new List<string>();
        }
    }
}
