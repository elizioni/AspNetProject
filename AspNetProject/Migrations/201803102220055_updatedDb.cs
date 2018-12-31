namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SumAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "SumAmount");
        }
    }
}
