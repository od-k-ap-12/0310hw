using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0310hw
{
    interface ISerialize
    {
        void XMLSerialize(Device dev,string path);
        void XMLDeserialize(Device dev,string path);
        void JSONSerialize(Device dev,string path);
        void JSONDeserialize(Device dev,string path);
    }
}
