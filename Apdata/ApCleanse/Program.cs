var diretorioAplicacao = AppDomain.CurrentDomain.BaseDirectory.Replace('/', '\\');

File.AppendAllText
($@"{diretorioAplicacao}\Log\Analitico_{DateTime.Now.ToString("yyyyMMdd")}.csv",
 $"Aplicação;Servidor;Registros excluídos;Espaço liberado(GB);Tempo de execução;\n");

foreach(var arg in args)
{
    try
    {
        Type type = Type.GetType($"ApCleanse.Classes.{arg}", false, true);
        object oClass = Activator.CreateInstance(type);
    }
    catch { continue; }
    
}