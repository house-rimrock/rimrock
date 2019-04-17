using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.APImodels
{
    public class RootObject<T>
    {
        public List<T> objects { get; set; }
    }
}
