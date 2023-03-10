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
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../data.json";
            Device dev = new Device("dev1","manufacturer1", 1);
            DeviceSerializer ds = new DeviceSerializer();
            ds.XMLSerialize(dev,path);
            ds.XMLDeserialize(dev, path);
            ds.JSONSerialize(dev, path);
            ds.JSONDeserialize(dev, path);

        }
    }
}
