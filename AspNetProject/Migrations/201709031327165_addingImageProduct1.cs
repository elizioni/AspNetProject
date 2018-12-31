namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingImageProduct1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "firstImage");
            DropColumn("dbo.Products", "secondImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "secondImage", c => c.String());
            AddColumn("dbo.Products", "firstImage", c => c.String());
        }
    }
}
