namespace ApBuild.Classes
{
    internal class Rotina
    {
        public Rotina(string parametros)
        {
            Arquivo = new Arquivo(parametros);
            Conexao = new Conexao(Arquivo);
            GeraHtml();
        }
        public Arquivo Arquivo { get; set; }
        public Conexao Conexao { get; set; }

        void GeraHtml()
        {
            var html = $"<link rel=\"stylesheet\" href=\"{Arquivo.CaminhoCss}\">\n<a class=\"dataAtualizacao\">Atualizado em: {DateTime.Now.ToString("dd/MM/yyyy' às 'HH:mm:ss")}</a><br><br>\n";
            html += "<table>\n";
            foreach (var descompasso in Conexao.ListaDescompassos)
            {
                html += Conexao.Campos;
                html += descompasso;
                
            }
            html += $"\n</table>\n";
            File.WriteAllText(Arquivo.CaminhoSaidaHtml, html);
        }
    }
}
