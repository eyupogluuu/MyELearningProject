namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_courseregister : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRegisters",
                c => new
                    {
                        CourseRegisterID = c.Int(nullable: false, identity: true),
                        studentID = c.Int(nullable: false),
                        courseID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseRegisterID)
                .ForeignKey("dbo.Courses", t => t.courseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.studentID, cascadeDelete: true)
                .Index(t => t.studentID)
                .Index(t => t.courseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseRegisters", "studentID", "dbo.Students");
            DropForeignKey("dbo.CourseRegisters", "courseID", "dbo.Courses");
            DropIndex("dbo.CourseRegisters", new[] { "courseID" });
            DropIndex("dbo.CourseRegisters", new[] { "studentID" });
            DropTable("dbo.CourseRegisters");
        }
    }
}
