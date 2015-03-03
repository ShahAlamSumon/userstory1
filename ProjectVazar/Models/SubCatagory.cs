using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class SubCatagory
    {
        public int SubCatagoryId { get; set; }
        public string Name { get; set; }
        public int CatagoryId { get; set; }


        public Catagory Catagorys { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}