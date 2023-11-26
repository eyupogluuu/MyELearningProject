namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_relation_course_instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "instructorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "instructorID");
            AddForeignKey("dbo.Courses", "instructorID", "dbo.Instructors", "instructorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "instructorID", "dbo.Instructors");
            DropIndex("dbo.Courses", new[] { "instructorID" });
            DropColumn("dbo.Courses", "instructorID");
        }
    }
}
