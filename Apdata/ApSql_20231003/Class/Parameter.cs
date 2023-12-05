using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApSql.Class
{
    [Serializable]
    [XmlRoot("Parameter"), XmlType("Parameter")]
    public class Parameter
    {
        [XmlElement("ConnectionString")]
        public string ConnectionString { get; set; }
        [XmlElement("SelectDatabase")]
        public string SelectDatabase { get; set; }
        [XmlArray("DatabaseList")]
        [XmlArrayItem("Database")]
        public List<string> DatabaseList { get; set; } = new List<string>();
    }
}
