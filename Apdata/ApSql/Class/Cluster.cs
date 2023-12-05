using System.Data;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ApSql.Class
{
    [Serializable]
    [XmlRoot("Cluster"), XmlType("Cluster")]
    public class Cluster
    {

        [XmlElement("Key")]
        public string Key { get; set; }
        [XmlArray("ClusterList")]
        [XmlArrayItem("Cluster")]
        public List<string> DatabaseList { get; set; } = new List<string>();

        public Cluster() { }

    }
}
