namespace ApCleanse.Classes
{
    internal class Work : Base
    {
        internal override void CarregarDiretorios()
        {
            foreach (var servidor in Servidores)
            {
                Resetar();
                Timer.Start();
                Mapear(servidor);
                CarregarArquivos(3);
                Timer.Stop();
                Logar(servidor);
            }
        }

        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminhoWorkin = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\WorkIn\\";
                var caminhoWorkout = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Application\\WorkOut\\";

                if (Directory.Exists(caminhoWorkin))
                    Diretorios.Add(caminhoWorkin);

                if (Directory.Exists(caminhoWorkout))
                    Diretorios.Add(caminhoWorkout);
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
                           s.EndsWith(".log", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".elf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".jlf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".zip", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".tmp", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase) ||
                           s.EndsWith(".ini", StringComparison.OrdinalIgnoreCase))
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
