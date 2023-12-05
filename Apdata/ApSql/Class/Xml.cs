using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
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
        public Cluster MainCluster { get; set; } = new Cluster();
        public List<Cluster> ClusterList { get; set; } = new List<Cluster>();
        public Xml()
        {
            ClusterList = LoadCluster();
            MainCluster = ClusterList.Where(x => x.Key == "All").FirstOrDefault();
        }

        public void SaveCluster(List<Cluster> clusterList)
        {
            var serializer = new XmlSerializer(typeof(List<Cluster>));
            serializer.Serialize(File.Create(".\\Xml\\Cluster.xml"), clusterList);
        }

        private List<Cluster> LoadCluster()
        {

            //var serializer = new XmlSerializer(typeof(List<Cluster>));


            //var cluster = new Cluster();
            //cluster.Key = "a";
            //cluster.DatabaseList = new List<string>();
            //cluster.DatabaseList.Add("asdf");
            //cluster.DatabaseList.Add("amvfnj");

            //List<Cluster> a = new List<Cluster>();
            //a.Add(cluster);

            //serializer.Serialize(File.Create(".\\Xml\\Cluster.xml"), clusterList);

            var serializer = new XmlSerializer(typeof(List<Cluster>));
            
            var clusterList = new List<Cluster>();

            using (var reader = new StreamReader(".\\Xml\\Cluster.xml"))
            {
                clusterList = (List<Cluster>)serializer.Deserialize(reader);
            }

            clusterList = clusterList.OrderBy(x => x.Key).ToList();
            return clusterList;
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
