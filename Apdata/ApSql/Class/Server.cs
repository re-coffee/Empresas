using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApSql.Class
{
    internal class Server : Master
    {
        public List<string> InstanceList { get; set; } = new List<string>();
        public Server() { }


        public void Move(DataGridViewRowCollection rows)
        {
            foreach (DataGridViewRow item in rows)
            {
                InstanceList.Add((string)item.Cells[0].Value);
            }
            InstanceList = InstanceList.Distinct().Select(x => x.Trim()).OrderBy(x => x).ToList();
        }

        public void Move(DataGridViewSelectedRowCollection rows)
        {
            foreach (DataGridViewRow item in rows)
            {
                InstanceList.Add((string)item.Cells[0].Value);
            }
            InstanceList = InstanceList.Distinct().Select(x => x.Trim()).OrderBy(x => x).ToList();
        }
        public void Clear()
        {
            InstanceList.Clear();
        }
    }
}
