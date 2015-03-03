using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string Name { get; set; }

        public ICollection<SubCatagory> SubCatagories { get; set; }

    }
}