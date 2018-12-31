namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataAnnotation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                 "dbo.AdProductViewModels",
                 c => new
                 {
                     Id = c.Int(nullable: false, identity: true),
                     Title = c.String(nullable: false, maxLength: 255),
                     AdDescription = c.String(),
                 })
                 .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            
            
        }
    }
}
