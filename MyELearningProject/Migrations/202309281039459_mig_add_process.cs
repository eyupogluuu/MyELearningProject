namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_process : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        processID = c.Int(nullable: false, identity: true),
                        studenID = c.Int(nullable: false),
                        courseID = c.Int(nullable: false),
                        student_studentID = c.Int(),
                    })
                .PrimaryKey(t => t.processID)
                .ForeignKey("dbo.Courses", t => t.courseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.student_studentID)
                .Index(t => t.courseID)
                .Index(t => t.student_studentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processes", "student_studentID", "dbo.Students");
            DropForeignKey("dbo.Processes", "courseID", "dbo.Courses");
            DropIndex("dbo.Processes", new[] { "student_studentID" });
            DropIndex("dbo.Processes", new[] { "courseID" });
            DropTable("dbo.Processes");
        }
    }
}
