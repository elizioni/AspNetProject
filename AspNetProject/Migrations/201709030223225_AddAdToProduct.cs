namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AdId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "AdId");
        }
    }
}
