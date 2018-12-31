namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingImage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ads", "Image");
            DropColumn("dbo.Products", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            AddColumn("dbo.Ads", "Image", c => c.String());
        }
    }
}
