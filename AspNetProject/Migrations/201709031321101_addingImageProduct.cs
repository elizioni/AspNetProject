namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingImageProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "firstImage", c => c.String());
            AddColumn("dbo.Products", "secondImage", c => c.String());
            DropColumn("dbo.Products", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            DropColumn("dbo.Products", "secondImage");
            DropColumn("dbo.Products", "firstImage");
        }
    }
}
