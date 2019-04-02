using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelLibrary.REST
{
    public class GeoLocation
    {
        public string Type { get; set; }
        public double[] Coordinates { get; set; }
    }
}
