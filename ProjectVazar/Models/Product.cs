using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int SubCatagoryId { get; set; }

        public SubCatagory SubCatagorys { get; set; }
        public ICollection<ProductPreview> ProductPreviews { get; set; }
        public ICollection<OrderList> OrderLists { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<WishList> WishLists { get; set; }
    }
}