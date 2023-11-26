namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_process2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Processes", "student_studentID", "dbo.Students");
            DropIndex("dbo.Processes", new[] { "student_studentID" });
            RenameColumn(table: "dbo.Processes", name: "student_studentID", newName: "studentID");
            AlterColumn("dbo.Processes", "studentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Processes", "studentID");
            AddForeignKey("dbo.Processes", "studentID", "dbo.Students", "studentID", cascadeDelete: true);
            DropColumn("dbo.Processes", "studenID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Processes", "studenID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Processes", "studentID", "dbo.Students");
            DropIndex("dbo.Processes", new[] { "studentID" });
            AlterColumn("dbo.Processes", "studentID", c => c.Int());
            RenameColumn(table: "dbo.Processes", name: "studentID", newName: "student_studentID");
            CreateIndex("dbo.Processes", "student_studentID");
            AddForeignKey("dbo.Processes", "student_studentID", "dbo.Students", "studentID");
        }
    }
}
