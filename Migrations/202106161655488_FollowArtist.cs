namespace TheGigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowArtist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FollowArtists",
                c => new
                    {
                        ArtistId = c.String(nullable: false, maxLength: 128),
                        FollowerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ArtistId, t.FollowerId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId, cascadeDelete: true)
                .Index(t => t.FollowerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FollowArtists", "FollowerId", "dbo.AspNetUsers");
            DropIndex("dbo.FollowArtists", new[] { "FollowerId" });
            DropTable("dbo.FollowArtists");
        }
    }
}
