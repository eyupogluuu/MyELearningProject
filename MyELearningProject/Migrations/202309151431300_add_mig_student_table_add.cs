namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_student_table_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        sname = c.String(),
                        ssurname = c.String(),
                        smail = c.String(),
                        spassword = c.String(),
                    })
                .PrimaryKey(t => t.studentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
