using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApCleanse.Classes
{
    internal class Fotos : Base
    {
        internal override void CarregarDiretorios()
        {
            foreach (var servidor in Servidores)
            {
                Resetar();
                Timer.Start();
                Mapear(servidor);
                CarregarArquivos(DiasAnteriores);
                Timer.Stop();
                Logar(servidor);
            }
        }

        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\WorkIn\\fotos\\";

                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
        internal override void CarregarArquivos(int diasAnteriores = 30)
        {
            foreach (var diretorio in Diretorios)
            {
                try
                {
                    Directory.GetFiles(diretorio, "*.*", SearchOption.AllDirectories)
                    .Where(x => !x.Contains("wfreports", StringComparison.OrdinalIgnoreCase))
                    .Where(s =>
                           s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||

                           s.EndsWith(".log", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".elf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".jlf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".zip", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".tmp", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".ini", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".raf", StringComparison.OrdinalIgnoreCase))
                    .Where(x =>
                           File.GetLastWriteTime(x).Date < DateTime.Today.AddDays(diasAnteriores * -1))
                    .ToList()
                    .ForEach(x =>
                           Arquivos.Add(x));
                }
                catch { continue; }
            }
            ExcluirArquivos();
        }
    }
}
