using Microsoft.Data.SqlClient;
using System.Data;

namespace ApTask
{
    public class Show : Base
    {
        public Show()
        {
            CreateFile(GetHtml());
        }

        public void CreateFile(string html)
        {
            File.WriteAllText(Cfgs["ShowOutput"], html);
        }

        public string GetHtml()
        {
            var html = $"<link rel=\"stylesheet\" href=\"{Cfgs["ShowCss"]}\">\r\n<a class=\"dataAtualizacao\">Atualizado em: {DateTime.Now.ToString("dd/MM/yyyy' às 'HH:mm:ss")}</a><br><br>\n";
            html += "<table>\n";
            var campos = "";
            var valores = "";

            using (var con = new SqlConnection(Context.ConnectionString()))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(Cfgs["Show"], con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                campos = "\t<tr>";
                                valores += "\n\t<tr>";

                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    campos += $"\n\t\t<th>{dr.GetName(i)}</th>";
                                    valores += $"\n\t\t<td>{dr[i]}</td>";
                                }
                                campos += "\n\t</tr>";
                                valores += "\n\t</tr>";
                            }
                        }
                    }
                }
                catch { }
            }
            return html + campos + valores + "\n</table>";
        }
    }
}