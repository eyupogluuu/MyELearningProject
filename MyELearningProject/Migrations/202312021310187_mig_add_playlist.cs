namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_playlist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        playlistID = c.Int(nullable: false, identity: true),
                        courseID = c.Int(nullable: false),
                        videolink = c.String(),
                    })
                .PrimaryKey(t => t.playlistID)
                .ForeignKey("dbo.Courses", t => t.courseID, cascadeDelete: true)
                .Index(t => t.courseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Playlists", "courseID", "dbo.Courses");
            DropIndex("dbo.Playlists", new[] { "courseID" });
            DropTable("dbo.Playlists");
        }
    }
}
