using System.Text.RegularExpressions;

namespace ApCleanse.Class
{
    internal class Rotina : Base
    {
        public Rotina(string arquivo) { Executar(arquivo); }
        private void Executar(string arquivo)
        {
            CarregarParametros(arquivo);
            ExecutarRotina();
        }
        private void CarregarParametros(string arquivo)
        {
            var LinhasParametros = File.ReadAllLines($@"{DiretorioApp}{arquivo}").ToList();

            foreach (var linha in LinhasParametros.Where(x => x.StartsWith("=>")).Select(s => s.Replace("=>", "").Trim())) DiretoriosVar.Add(linha);
            foreach (var linha in LinhasParametros.Where(x => x.StartsWith("->")).Select(s => s.Replace("->", "").Trim())) Diretorios.Add(linha);
            foreach (var linha in LinhasParametros.Where(x => x.StartsWith("~>")).Select(s => s.Replace("~>", "").Trim())) Servidores.Add(linha);
            foreach (var linha in LinhasParametros.Where(x => x.StartsWith(".>")).Select(x => x.Replace(".>", "").Trim())) Excecoes.Add(linha);

            try
            {
                Titulo =
                    LinhasParametros.Where(x =>
                                           x.StartsWith("Titulo", StringComparison.OrdinalIgnoreCase))
                                    .FirstOrDefault()
                                    .Split(":")[1]
                                    .Trim();
            }
            catch { }

            Diretorio =
                LinhasParametros
                .Where(x => x.StartsWith("Diretorio", StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault()
                .Split(":")[1]
                .Trim();

            Disco =
                LinhasParametros
                .Where(x => x.StartsWith("Disco", StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault()
                .Split(":")[1]
                .Trim();

            Extensoes =
                LinhasParametros
                .Where(x => x.StartsWith("Extensoes", StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault()
                .Split(":")[1]
                .Split("||")
                .Select(x => x.Trim())
                .ToList();

            ArquivoLog = $"{DiretorioApp}log\\{Titulo}_{DateTime.Now.Date.ToString("yyyyMMdd")}.csv";
            Directory.CreateDirectory($"{DiretorioApp}log\\");

            if (!File.Exists(ArquivoLog))
            {
                File.AppendAllText(ArquivoLog, "Servidor;Clientes;Diretórios analisados;Arquivos excluídos;Espaço liberado (GB);Tempo de execução;Data;\n");
            }
                
        }

        private void ExecutarRotina()
        {
            Regex rx = new Regex("(i?)C[0-9]{3}_.+");
            foreach (var servidor in Servidores)
            {
                var dir = Diretorio
                    .Replace("#SERVIDOR#", servidor, StringComparison.OrdinalIgnoreCase)
                    .Replace("#DISCO#", Disco, StringComparison.OrdinalIgnoreCase);

                Clientes =
                    Directory.GetDirectories(dir)
                    .Where(x => rx.IsMatch(x))
                    .Select(x => x.Replace(dir, ""))
                    .ToList();

                foreach (var cliente in Clientes)
                {
                    Diretorios.AddRange(
                        DiretoriosVar
                        .Select(d =>
                                d.Replace("#SERVIDOR#", servidor, StringComparison.OrdinalIgnoreCase)
                                 .Replace("#CLIENTE#", cliente, StringComparison.OrdinalIgnoreCase)
                                 .Replace("#DISCO#", Disco, StringComparison.OrdinalIgnoreCase)
                                 .Trim())
                                 .ToList());
                }
                Excluir(servidor);
            }
        }
        private void Excluir(string servidor)
        {
            Timer.Start();
            ContadorDiretorios = 0;
            foreach (var diretorio in Diretorios)
            {
                var config = diretorio.Split("||");
                var dir = config[0].Trim();
                var dia = int.Parse(config[1].Trim());
                var pesquisa = SearchOption.TopDirectoryOnly;

                if (config.Length == 3) pesquisa = SearchOption.AllDirectories;
                if (Directory.Exists(dir))
                {
                    Mapear(dir, dia, pesquisa);
                    ContadorDiretorios++;
                }
                    
            }

            foreach (var arquivo in Arquivos)
            {
                try {
                    var tamanho = new FileInfo(arquivo).Length;
                    File.Delete(arquivo);
                    ContadorGigabytes += tamanho;
                    ContadorRegistros++; }
                catch { }
            }
            Timer.Stop();

            Logar(servidor);
        }

        private void Mapear(string diretorio, int diasAnteriores, SearchOption pesquisa)
        {

            Directory.GetFiles(diretorio, "*.*", pesquisa)
                    .Where(x => Extensoes.Any(e => x.EndsWith(e, StringComparison.OrdinalIgnoreCase)))
                    .Where(x => !Excecoes.Any(e => x.Contains(e, StringComparison.OrdinalIgnoreCase)))
                    .Where(x =>
                           File.GetLastWriteTime(x).Date < DateTime.Today.AddDays(diasAnteriores * -1))
                    .ToList()
                    .ForEach(x => Arquivos.Add(x));
        }

        private void Logar(string servidor)
        {
            if(ContadorRegistros > 0)
                File.AppendAllText(ArquivoLog,
                    $"{servidor};" +
                    $"{Clientes.Count()};" +
                    $"{ContadorDiretorios};" +
                    $"{ContadorRegistros};" +
                    $"{Math.Round(ContadorGigabytes / 1000d / 1000d / 1000d, 3).ToString().Replace(".", ",")};" +
                    $"{Timer.Elapsed.ToString("hh\\:mm\\:ss")};" +
                    $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")};\n");

            Clientes.Clear();
            Diretorios.Clear();
            Arquivos.Clear();
            Timer.Reset();

            ContadorGigabytes = 0;
            ContadorRegistros = 0;
        }
    }
}
