using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models
{
    public class FavRetailer
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public int RegionID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public User User { get; set; }
    }
}
