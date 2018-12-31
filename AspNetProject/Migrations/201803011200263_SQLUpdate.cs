using System.IO;

namespace AspNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLUpdate : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO [dbo].[Products] ( [Publisher], [Description], [Price], [AdId], [firstImage], [secondImage]) VALUES ( N'John', N'Single fish bait only today for 10.99!', 10.99, 3, N'https://ae01.alicdn.com/kf/HTB1.0BPoBTH8KJjy0Fiq6ARsXXa8/1pc-Crank-Bait-Plastic-Hard-Lures-30mm-Salmon-Fishing-Baits-Crankbait-With-Single-Hook-Wobblers-Freshwater.jpg_640x640.jpg', N'https://ae01.alicdn.com/kf/HTB1lBMKXjQnBKNjSZSgq6xHGXXaD/20g-Jigging-Lure-with-VMC-single-hook-Metal-Fishing-Lures-Micro-Lead-Fish-Bait-Sea-bass.jpg')");
        }
        
        public override void Down()
        {
        }
    }
}
