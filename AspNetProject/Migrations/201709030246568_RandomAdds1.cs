namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RandomAdds1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AdId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductAdId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductAdId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "AdId");
        }
    }
}
