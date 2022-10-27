namespace ApCleanse.Classes
{
    internal class ApAccessServer : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\D$\\{cliente}\\Server\\Access\\Log\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
    }
}
