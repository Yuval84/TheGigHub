namespace TheGigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowArtist1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FollowArtists", "FollowerId", "dbo.AspNetUsers");
            DropPrimaryKey("dbo.FollowArtists");
            AddColumn("dbo.FollowArtists", "FollowedId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.FollowArtists", new[] { "FollowedId", "FollowerId" });
            CreateIndex("dbo.FollowArtists", "FollowedId");
            AddForeignKey("dbo.FollowArtists", "FollowedId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.FollowArtists", "FollowerId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.FollowArtists", "ArtistId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FollowArtists", "ArtistId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.FollowArtists", "FollowerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FollowArtists", "FollowedId", "dbo.AspNetUsers");
            DropIndex("dbo.FollowArtists", new[] { "FollowedId" });
            DropPrimaryKey("dbo.FollowArtists");
            DropColumn("dbo.FollowArtists", "FollowedId");
            AddPrimaryKey("dbo.FollowArtists", new[] { "ArtistId", "FollowerId" });
            AddForeignKey("dbo.FollowArtists", "FollowerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
