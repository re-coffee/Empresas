namespace ApQuery.Class
{
    internal class Base
    {
        public Base(string conf)
        {
            foreach (var linha in File.ReadAllLines(conf))
            {
                try { Conf.Add(linha.Split("=", 2)[0].Trim(), linha.Split("=", 2)[1].Trim()); }
                catch { continue; }
            }
            Query = File.ReadAllText(Conf["Query"]);
            Go();
        }
        public Dictionary<string, string> Conf { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public string Query { get; set; }
        public string Fields { get; set; }
        public List<string> Values { get; set; } = new List<string>();
        public virtual void Go() { }
    }
}
