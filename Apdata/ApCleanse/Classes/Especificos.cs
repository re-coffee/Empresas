namespace ApCleanse.Classes
{
    internal class Especificos : Base
    {
        internal override void CarregarDiretorios()
        {
            Resetar();
            Timer.Start();
            foreach (var especifico in Especificos)
            {
                if (Directory.Exists(especifico))
                    Diretorios.Add(especifico);
            }
            CarregarArquivos(DiasAnteriores);
            Timer.Stop();
            Logar("Especifico");
        }
    }
}
