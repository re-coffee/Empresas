using System.Text;

namespace ApQuery.Class
{
    internal class Action : Base
    {
        public Action(string conf) : base(conf) { }

        public override void Go()
        {
            var con = new Connection(this).Go();
            Fields = con.Fields;
            Values = con.Values;
            File.WriteAllText(Conf["Output"], Format(), Encoding.Default);
        }
        public string Format()
        {

            var html = $"<link rel=\"stylesheet\" href=\"{Conf["Css"]}\">\n";

            try { html += File.ReadAllText(Conf["Complement"]); html += "\n<br>\n"; }
            catch { }

            try { html += Conf["input"]; html += "\n<br>\n"; }
            catch { }
            
            html += $"\n<table id =\"{Conf["Id"]}\" class=\"{Conf["Class"]}\">\n";
            html += Fields;
            foreach(var block in Values)
            {
                html += block;
            }
            html += "</table>\n";

            try { html += $"\n{File.ReadAllText(Conf["Script"])}"; }
            catch { }
            Console.WriteLine(Fields);
            return html;
        }
    }
}
