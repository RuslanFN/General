namespace AppTeam101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        achive_way = c.String(),
                        locality = c.String(),
                        first_name = c.String(),
                        second_name = c.String(),
                        year = c.String(),
                        eventname = c.String(),
                        place = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        News_Name = c.String(),
                        About = c.String(),
                        Date = c.String(),
                        UrlImg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
            DropTable("dbo.Events");
        }
    }
}
