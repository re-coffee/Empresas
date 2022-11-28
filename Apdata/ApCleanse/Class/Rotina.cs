using System.Collections.Concurrent;
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

            Extensoes =
                LinhasParametros
                .Where(x => x.StartsWith("Extensões", StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault()
                .Split(":")[1]
                .Split("||")
                .Select(x => x.Trim())
                .ToList();

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
        }

        private void ExecutarRotina()
        {
            ResetarVariaveis();
            Regex rx = new Regex("(i?)C[0-9]{3}_.+");
            foreach (var servidor in Servidores)
            {
                var dir = Diretorio
                    .Replace("#SERVIDOR", servidor, StringComparison.OrdinalIgnoreCase)
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
                Clientes.Clear();
                Excluir();
            }
        }
        private void Excluir()
        {
            foreach(var diretorio in Diretorios)
            {
                var config = diretorio.Split("||");
                var dir = config[0].Trim();
                var dia = int.Parse(config[1].Trim());
                var pesquisa = SearchOption.TopDirectoryOnly;

                if (config.Length == 3) pesquisa = SearchOption.AllDirectories;
                if (Directory.Exists(dir)) Mapear(dir, dia, pesquisa);
            }

            foreach (var arquivo in Arquivos)
            {
                Console.WriteLine
                    ($"{File.GetLastWriteTime(arquivo).ToString("dd/MM/yyyy hh:mm")} - " +
                    $"{arquivo}");
            }

            Arquivos.Clear();
        }

        private void Mapear(string diretorio, int diasAnteriores, SearchOption pesquisa)
        {

            Directory.GetFiles(diretorio, "*.*", pesquisa)
                    .Where(x => Extensoes.Any(e => x.Contains(e, StringComparison.OrdinalIgnoreCase)))
                    .Where(x => !Excecoes.Any(e => x.Contains(e, StringComparison.OrdinalIgnoreCase)))
                    .Where(x =>
                           File.GetLastWriteTime(x).Date < DateTime.Today.AddDays(diasAnteriores * -1))
                    .ToList()
                    .ForEach(x => Arquivos.Add(x));
        }

        private void ResetarVariaveis()
        {
            Arquivos.Clear();
            Logs.Clear();
            Timer.Reset();
            ParcialGigabytes = 0;
            ParcialRegistros = 0;
        }
    }
}
