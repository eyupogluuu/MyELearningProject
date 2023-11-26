namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_comment_relations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "studentID", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "coureseID", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "course_courseID", c => c.Int());
            CreateIndex("dbo.Comments", "studentID");
            CreateIndex("dbo.Comments", "course_courseID");
            AddForeignKey("dbo.Comments", "course_courseID", "dbo.Courses", "courseID");
            AddForeignKey("dbo.Comments", "studentID", "dbo.Students", "studentID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "studentID", "dbo.Students");
            DropForeignKey("dbo.Comments", "course_courseID", "dbo.Courses");
            DropIndex("dbo.Comments", new[] { "course_courseID" });
            DropIndex("dbo.Comments", new[] { "studentID" });
            DropColumn("dbo.Comments", "course_courseID");
            DropColumn("dbo.Comments", "coureseID");
            DropColumn("dbo.Comments", "studentID");
        }
    }
}
