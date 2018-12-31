namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ImageId");
            AddForeignKey("dbo.Products", "ImageId", "dbo.Images", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ImageId", "dbo.Images");
            DropIndex("dbo.Products", new[] { "ImageId" });
            DropColumn("dbo.Products", "ImageId");
        }
    }
}
