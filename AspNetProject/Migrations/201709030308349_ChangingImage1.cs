namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingImage1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "Image", c => c.String());
            AddColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Image");
            DropColumn("dbo.Ads", "Image");
        }
    }
}
