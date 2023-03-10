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
    [Serializable]
    [DataContract]
    public class Device
    {
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public double Price { get; set; }
        public Device(string _Model, string _Manufacturer, double _Price)
        {
            Model = _Model;
            Manufacturer = _Manufacturer;
            Price = _Price;
        }
        public Device()
        {
            Model = null;
            Manufacturer = null;
            Price = 0;
        }
    }
}
