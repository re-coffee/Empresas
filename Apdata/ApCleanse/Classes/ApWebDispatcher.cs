namespace ApCleanse.Classes
{
    internal class ApWebDispatcher : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\D$\\Portais\\{cliente.Replace("_OFI", "_APW").Replace("_HOM", "_APW")}\\Server\\ApWebDispatcher\\.net\\Logs\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }

        }
    }
}
