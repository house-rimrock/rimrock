using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models
{
    public class Retailer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int RegionID { get; set; }
    }
}
