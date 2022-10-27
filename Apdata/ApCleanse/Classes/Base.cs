using System.Diagnostics;

namespace ApCleanse.Classes
{
    internal class Base
    {
        public Base()
        {
            CarregarParametros();
            CarregarDiretorios();
        }
        internal string? CaminhoAplicacao { get; set; } = AppDomain.CurrentDomain.BaseDirectory.Replace('/', '\\');
        internal string? DataAtual { get; set; } = DateTime.Now.ToString("yyyyMMdd");
        internal List<string>? Diretorios { get; set; } = new List<string>();
        internal List<string>? Arquivos { get; set; } = new List<string>();
        internal List<string>? Logs { get; set; } = new List<string>();
        internal int? TotalRegistros { get; set; } = 0;
        internal Stopwatch Timer { get; set; } = new Stopwatch();

        /*Parametros*/
        internal List<string>? Clientes { get; set; } = new List<string>();
        internal List<string>? Servidores { get; set; } = new List<string>();
        internal List<string>? Mensagerias { get; set; } = new List<string>();
        internal List<string>? Especificos { get; set; } = new List<string>();

        /*Contadores*/
        internal int ContadorRegistros { get; set; } = 0;
        internal double ContadorGigabyte { get; set; } = 0;

        /*Metodos*/
        internal void CarregarParametros()
        {
            var linhas = File.ReadAllLines($@"{CaminhoAplicacao}Parametros.txt");

            Clientes =
                linhas.SkipWhile(s => s != "<clientes>").Skip(1).TakeWhile(s => s != "</clientes>").ToList();

            Servidores =
                linhas.SkipWhile(s => s != "<servidores>").Skip(1).TakeWhile(s => s != "</servidores>").ToList();

            Mensagerias =
                linhas.SkipWhile(s => s != "<mensagerias>").Skip(1).TakeWhile(s => s != "</mensagerias>").ToList();

            Especificos =
                linhas.SkipWhile(s => s != "<especificos>").Skip(1).TakeWhile(s => s != "</especificos>").ToList();
        }

        internal virtual void CarregarDiretorios()
        {
            foreach (var servidor in Servidores)
            {
                Resetar();
                Timer.Start();
                Mapear(servidor);
                CarregarArquivos();
                Timer.Stop();
                Logar(servidor);
            }
        }

        internal virtual void Mapear(string servidor) { }

        internal virtual void CarregarArquivos(int diasAnteriores = 30)
        {
            foreach (var diretorio in Diretorios)
            {
                try
                {
                    Directory.GetFiles(diretorio, "*.*", SearchOption.TopDirectoryOnly)
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

        internal void ExcluirArquivos()
        {
            foreach (var arquivo in Arquivos)
            {
                try
                {
                    var tamanho = new FileInfo(arquivo).Length;
                    File.Delete(arquivo);
                    ContadorRegistros++;
                    ContadorGigabyte += tamanho;
                }
                catch { continue; }
            }
        }

        internal void Logar(string servidor)
        {
            if (ContadorRegistros == 0)
            {
                return;
            }
            try
            {
                Logs.Add($"{GetType().Name};{servidor};{ContadorRegistros};{Math.Round(ContadorGigabyte / 1000d / 1000d / 1000d, 3).ToString().Replace(".", ",")};{Timer.Elapsed.ToString("hh\\:mm\\:ss\\.fff")};");
                File.AppendAllLines
                    ($@"{CaminhoAplicacao}\Log\Analitico_{DataAtual}.csv",
                    Logs);
            }
            catch { }
        }

        internal void Resetar()
        {
            Diretorios.Clear();
            Arquivos.Clear();
            Logs.Clear();
            Timer.Restart();
            ContadorGigabyte = 0;
            ContadorRegistros = 0;
        }
    }
}
