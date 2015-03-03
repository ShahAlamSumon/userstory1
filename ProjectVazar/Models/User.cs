using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int MobileNo { get; set; }
        public string Role { get; set; }

        public ICollection<Location> Locations { get; set; }
        public ICollection<OrderList> OrderLists { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<WishList> WishLists { get; set; }
    }
}