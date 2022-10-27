namespace Hefesto
{
    public class IndexView : Panteao.Web.Index
    {
        public string Html { get; set; }
        public IndexView(string transacao)
        {
            Html = Gerar(transacao);
        }
    }
}
