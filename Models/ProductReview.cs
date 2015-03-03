using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class ProductReview
    {
        public int ProductReviewId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public Product Products { get; set; }
        public User Users { get; set; }
    }
}