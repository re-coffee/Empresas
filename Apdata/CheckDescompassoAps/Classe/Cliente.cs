using System;
using System.Collections.Generic;
using System.Text;

namespace CheckDescompassoAps
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Base { get; set; }
        public string StringConexao { get; set; }
        public Cliente(string nomeCliente, string banco, string stringConexao)
        {
            NomeCliente = nomeCliente;
            Base = banco;
            StringConexao = stringConexao;
        }
    }
}
