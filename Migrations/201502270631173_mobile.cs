namespace ProjectVazar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mobile : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MobileNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "MobileNo", c => c.Int(nullable: false));
        }
    }
}
