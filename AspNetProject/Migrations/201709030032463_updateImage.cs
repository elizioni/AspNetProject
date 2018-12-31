namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "ImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ads", "ImageId");
            AddForeignKey("dbo.Ads", "ImageId", "dbo.Images", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ads", "ImageId", "dbo.Images");
            DropIndex("dbo.Ads", new[] { "ImageId" });
            DropColumn("dbo.Ads", "ImageId");
        }
    }
}
