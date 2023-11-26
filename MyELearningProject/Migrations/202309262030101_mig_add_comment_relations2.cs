namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_comment_relations2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "course_courseID", "dbo.Courses");
            DropIndex("dbo.Comments", new[] { "course_courseID" });
            RenameColumn(table: "dbo.Comments", name: "course_courseID", newName: "courseID");
            AlterColumn("dbo.Comments", "courseID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "courseID");
            AddForeignKey("dbo.Comments", "courseID", "dbo.Courses", "courseID", cascadeDelete: true);
            DropColumn("dbo.Comments", "coureseID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "coureseID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Comments", "courseID", "dbo.Courses");
            DropIndex("dbo.Comments", new[] { "courseID" });
            AlterColumn("dbo.Comments", "courseID", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "courseID", newName: "course_courseID");
            CreateIndex("dbo.Comments", "course_courseID");
            AddForeignKey("dbo.Comments", "course_courseID", "dbo.Courses", "courseID");
        }
    }
}
