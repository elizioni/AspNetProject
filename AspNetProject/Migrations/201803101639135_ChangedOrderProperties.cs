namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedOrderProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "SumAmount");
            DropColumn("dbo.Orders", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "SumAmount", c => c.Int(nullable: false));
        }
    }
}
