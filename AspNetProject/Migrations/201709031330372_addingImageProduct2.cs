namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingImageProduct2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "firstImage", c => c.String());
            AddColumn("dbo.Products", "secondImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "secondImage");
            DropColumn("dbo.Products", "firstImage");
        }
    }
}
