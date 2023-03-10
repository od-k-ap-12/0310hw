using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace _0310hw
{
    public class DeviceSerializer:ISerialize
    {
        public void XMLSerialize(Device dev, string path)
        {
            dev = new Device("dev1", "manufacturer1", 1);
            FileStream stream = new FileStream("../../data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Device));
            serializer.Serialize(stream, dev);
            stream.Close();
        }

        public void XMLDeserialize(Device dev, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Device));
            dev = (Device)serializer.Deserialize(stream);
            Console.WriteLine(dev.Model + "	" + dev.Manufacturer + "	" + dev.Price);
            stream.Close();
        }

        public void JSONSerialize(Device dev, string path)
        {
            FileStream stream = new FileStream("../../data.json", FileMode.Create);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            jsonFormatter.WriteObject(stream, dev);
            stream.Close();
        }

        public void JSONDeserialize(Device dev, string path)
        {
            FileStream stream = new FileStream("../../data.json", FileMode.Open);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            dev = (Device)jsonFormatter.ReadObject(stream);
            Console.WriteLine(dev.Model + "	" + dev.Manufacturer + "	" + dev.Price);
            stream.Close();
        }
    }
}
