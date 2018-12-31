namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataAnnotation1 : DbMigration
    {
        public override void Up()
        {
            Sql("DROP TABLE AdProductViewModels");
        }
        
        public override void Down()
        {
        }
    }
}
