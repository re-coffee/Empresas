namespace ApCleanse.Classes
{
    internal class ImportExport : Base
    {
        internal override void CarregarDiretorios()
        {
            foreach (var servidor in Servidores)
            {
                Resetar();
                Timer.Start();
                Mapear(servidor);
                CarregarArquivos(5);
                Timer.Stop();
                Logar(servidor);
            }
        }

        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminhoImport = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\import\\";
                var caminhoImportParcial = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\import_parcial\\";
                var caminhoExport = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\import\\";

                if (Directory.Exists(caminhoImport))
                    Diretorios.Add(caminhoImport);

                if (Directory.Exists(caminhoImportParcial))
                    Diretorios.Add(caminhoImportParcial);

                if (Directory.Exists(caminhoExport))
                    Diretorios.Add(caminhoExport);
            }
        }
        internal override void CarregarArquivos(int diasAnteriores = 30)
        {
            foreach (var diretorio in Diretorios)
            {
                try
                {
                    Directory.GetFiles(diretorio, "*.*", SearchOption.AllDirectories)
                    .Where(s =>
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
                           File.GetLastWriteTime(x) < DateTime.Today.AddDays(diasAnteriores * -1))
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
