namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        testimonialID = c.Int(nullable: false, identity: true),
                        nameSurname = c.String(),
                        title = c.String(),
                        imageUrl = c.String(),
                        comment = c.String(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.testimonialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
        }
    }
}
