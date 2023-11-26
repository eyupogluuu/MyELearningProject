namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseID = c.Int(nullable: false, identity: true),
                        tittle = c.String(),
                        price = c.Int(nullable: false),
                        duration = c.Int(nullable: false),
                        imageUrl = c.String(),
                    })
                .PrimaryKey(t => t.courseID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
