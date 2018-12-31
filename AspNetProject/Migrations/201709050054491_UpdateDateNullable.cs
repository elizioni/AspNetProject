namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ads", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ads", "Date", c => c.DateTime(nullable: false));
        }
    }
}
