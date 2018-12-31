namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RandomAdds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductAdId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "AdId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "AdId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductAdId");
        }
    }
}
