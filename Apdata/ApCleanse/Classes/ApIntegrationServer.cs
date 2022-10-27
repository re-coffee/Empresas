namespace ApCleanse.Classes
{
    internal class ApIntegrationServer : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Integration\\Log\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
    }
}
