using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelLibrary.REST
{
    public class MeteoriteLanding
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Fall { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public double Mass { get; set; }
        public string NameType { get; set; }
        public string RecClass { get; set; }
        public double RecLAT { get; set; }
        public double RecLONG { get; set; }
        public DateTime Year { get; set; }
    }
}
