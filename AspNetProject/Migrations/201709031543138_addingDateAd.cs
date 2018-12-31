namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingDateAd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "Date");
        }
    }
}
