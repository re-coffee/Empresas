namespace ApCleanse.Classes
{
    internal class ApAgentService : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\D$\\{cliente}\\Server\\ApAgentService\\Log\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
    }
}
