using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class WishList
    {
        public int WishListId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public User Users { get; set; }
        public Product Products { get; set; }

    }
}