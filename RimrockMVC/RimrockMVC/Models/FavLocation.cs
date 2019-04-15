using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models
{
    public class FavLocation
    {
        int ID { get; set; }
        int UserID { get; set; }
        int RegionID { get; set; }
        string Name { get; set; }
        string Cost { get; set; }
    }
}
