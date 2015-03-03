using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}