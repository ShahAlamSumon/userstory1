namespace ProjectVazar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VazarDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        CatagoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CatagoryId);
            
            CreateTable(
                "dbo.SubCatagories",
                c => new
                    {
                        SubCatagoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubCatagoryId)
                .ForeignKey("dbo.Catagories", t => t.CatagoryId, cascadeDelete: true)
                .Index(t => t.CatagoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        SubCatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.SubCatagories", t => t.SubCatagoryId, cascadeDelete: true)
                .Index(t => t.SubCatagoryId);
            
            CreateTable(
                "dbo.OrderLists",
                c => new
                    {
                        OrderListId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderListId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        MobileNo = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Longitude = c.String(),
                        Latitude = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        ProductReviewId = c.Int(nullable: false, identity: true),
                        Review = c.String(),
                        Rating = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductReviewId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        WishListId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WishListId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductPreviews",
                c => new
                    {
                        ProductPreviewId = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductPreviewId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCatagoryId", "dbo.SubCatagories");
            DropForeignKey("dbo.ProductPreviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.WishLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.WishLists", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductReviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProductReviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.Locations", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderLists", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SubCatagories", "CatagoryId", "dbo.Catagories");
            DropIndex("dbo.ProductPreviews", new[] { "ProductId" });
            DropIndex("dbo.WishLists", new[] { "ProductId" });
            DropIndex("dbo.WishLists", new[] { "UserId" });
            DropIndex("dbo.ProductReviews", new[] { "UserId" });
            DropIndex("dbo.ProductReviews", new[] { "ProductId" });
            DropIndex("dbo.Locations", new[] { "UserId" });
            DropIndex("dbo.OrderLists", new[] { "ProductId" });
            DropIndex("dbo.OrderLists", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "SubCatagoryId" });
            DropIndex("dbo.SubCatagories", new[] { "CatagoryId" });
            DropTable("dbo.ProductPreviews");
            DropTable("dbo.WishLists");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.Locations");
            DropTable("dbo.Users");
            DropTable("dbo.OrderLists");
            DropTable("dbo.Products");
            DropTable("dbo.SubCatagories");
            DropTable("dbo.Catagories");
        }
    }
}
