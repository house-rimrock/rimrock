using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models
{
    public class FavRetailer
    {
        [Key]
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int UserId { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
    }
}
