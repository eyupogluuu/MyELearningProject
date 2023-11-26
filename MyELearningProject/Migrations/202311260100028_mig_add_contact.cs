namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        contactID = c.Int(nullable: false, identity: true),
                        nameSurname = c.String(),
                        mail = c.String(),
                        subject = c.String(),
                        message = c.String(),
                    })
                .PrimaryKey(t => t.contactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
