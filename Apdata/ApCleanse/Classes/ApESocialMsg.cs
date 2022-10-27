namespace ApCleanse.Classes
{
    internal class ApESocialMsg : Base
    {
        internal override void Mapear(string servidor)
        {
            foreach (var mensageria in Mensagerias)
            {
                var caminho = $"\\\\{servidor}\\d$\\{mensageria}\\Server\\ApESocialMsg\\Log\\";
                if (Directory.Exists(caminho))
                    Diretorios.Add(caminho);
            }
        }
    }
}
