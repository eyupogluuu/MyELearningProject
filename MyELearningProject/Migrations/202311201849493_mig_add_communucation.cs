namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_communucation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Communucations",
                c => new
                    {
                        communcationID = c.Int(nullable: false, identity: true),
                        office = c.String(),
                        phone = c.String(),
                        mail = c.String(),
                        mapUrl = c.String(),
                    })
                .PrimaryKey(t => t.communcationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Communucations");
        }
    }
}
