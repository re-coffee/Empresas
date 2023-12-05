using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApSql.Class
{
    internal class Xml
    {
        public Xml()
        {
            
        }
        public void SaveCluster(List<Cluster> cluster)
        {

        }
        public List<Cluster> LoadCluster()
        {
            
            var serializer = new XmlSerializer(typeof(List<Cluster>));


            var cluster = new Cluster();
            cluster.Key = "a";
            cluster.DatabaseList = new List<string>();
            cluster.DatabaseList.Add("asdf");
            cluster.DatabaseList.Add("amvfnj");

            List<Cluster> a = new List<Cluster>();
            a.Add(cluster);

            //serializer.Serialize(File.Create(".\\Xml\\Cluster.xml"), clusterList);

            return a;
        }

        public Parameter LoadParameter()
        {
            var serializer = new XmlSerializer(typeof(Parameter));
            var parameter = new Parameter();

            using (var reader = new StreamReader(".\\Xml\\Parameter.xml"))
            {
                parameter = (Parameter)serializer.Deserialize(reader);
            }

            //serializer.Serialize(File.Create(".\\Xml\\Parameter.xml"), parameter);

            return parameter;
        }
    }
}
