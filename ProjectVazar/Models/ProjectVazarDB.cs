using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class ProjectVazarDB:DbContext
    {
        public ProjectVazarDB(): base("VazarConnStr")
        {
            
        }

        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPreview> ProductPreviews { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<SubCatagory> SubCatagories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WishList> WishLists { get; set; }
    }
}