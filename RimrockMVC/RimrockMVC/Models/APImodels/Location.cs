using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public int RegionID { get; set; }
    }
}
