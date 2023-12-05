using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApSql.Class
{
    internal class Query : Master
    {
        public List<string> CommandList { get; set; } = new List<string>();
        public Query() { }
        public void Clear()
        {
            CommandList.Clear();
        }
        public void Move(string[] queries)
        {
            foreach(var item in queries)
            {
                CommandList.Add(item);
            }

            CommandList =
            CommandList
                            .Select(x => x.Trim())
                            .Distinct()
                            .Where(x => !string.IsNullOrEmpty(x))
                            //.OrderBy(x => x)
                            .ToList();
        }
    }
}
