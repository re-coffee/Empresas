namespace ApCleanse.Classes
{
    internal class ApLoadBalancerServer : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var cliente in Clientes)
            {
                var caminho = $"\\\\{servidor}\\d$\\{cliente}\\Server\\ApLoadBalancer\\Log\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
    }
}
