using Panteao;
using System.ServiceProcess;

namespace Cronos
{
    internal class Base
    {
        public Base()
        {
            foreach (var servidor in Servidores)
            {
                IdServidor = servidor.Id;
                ScServices =
                    ServiceController
                    .GetServices(servidor.Ip)
                    .Where(x => x.ServiceName.Contains(GetType().Name, StringComparison.OrdinalIgnoreCase) &&
                                x.StartType != ServiceStartMode.Disabled)
                    .ToList();
                Atualizar();
            }
            Console.WriteLine("Servicos Atualizados");
            Console.WriteLine("____________________");
            Console.WriteLine("titulo, idcliente, idservidor, idservidorbanco, instanciabanco, porta");
            foreach (var item in ServicosAtualizados)
            {
                Console.WriteLine("");
                Console.WriteLine(item.Titulo);
                Console.WriteLine(item.IdCliente);
                Console.WriteLine(item.IdServidor);
                Console.WriteLine(item.IdServidorBanco);
                Console.WriteLine(item.InstanciaBanco);
                Console.WriteLine(item.Porta);
                Console.WriteLine("");
            }
            
            Console.WriteLine("Alterados/Inseridos :" + Insercoes + " Registros");

        }
        internal List<Servidor>? Servidores { get; set; }
            = new Context().Servidores?.Where(x => x.IdCategoria > 1).ToList();
        internal List<Servico>? Servicos { get; set; } = new List<Servico>();
        internal List<Servico>? ServicosAtualizados { get; set; } = new List<Servico>();
        internal List<ServiceController> ScServices { get; set; } = new List<ServiceController>();
        internal int? IdServidor { get; set; } = 0;
        internal int? Insercoes { get; set; } = 0;
        public virtual void Atualizar() { }
    }
}
