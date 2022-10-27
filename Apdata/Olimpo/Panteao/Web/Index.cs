using Microsoft.Data.SqlClient;
using System.Data;

namespace Panteao.Web
{
    public class Index
    {
        public static string Gerar(string transacao)
        {
            return View(transacao);
        }

        private static string View(string transacao)
        {

            var dataTable = new DataTable();
            using (var da = new SqlDataAdapter($"SELECT * FROM vw.{transacao};", Context.StringConexao()))
            {
                try
                {
                    da.Fill(dataTable);
                }
                catch
                {
                    return ("<div style=\"width: 100%; text-align: center;\"><b>Não há uma view válida para esse relatório</b></div>");
                }

            }
            return DataTableString(dataTable, transacao);
        }
        private static string DataTableString(DataTable datatable, string transacao)
        {
            var html = "<table id=\"DataTable\" class=\"datatable compact hover stripe\"><thead><tr>";
            var id = 0;
            int qtdCol = datatable.Columns.Count;

            foreach (var item in datatable.Columns)
            {
                html += $"<th>{item}</th>";
            }
            html += "</tr></thead><tbody>";

            foreach (DataRow item in datatable.Rows)
            {
                html += "<tr>";
                for (int i = 0; i < qtdCol; i++)
                {
                    if (i == 0)
                    {
                        try { id = (int)item[i]; }
                        catch { }
                    }
                        
                    html += $"<td><a href=\"..\\{transacao}\\Detalhes\\{id}\">{item[i]}</td>";
                }
                id = 0;
                html += "</tr>";
            }
            html += "</tbody></table>";
            return html;
        }
    }
}
