namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_remove_contact : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Contacts");
        }
        
        public override void Down()
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
                        office = c.String(),
                        mobile = c.String(),
                        email = c.String(),
                        mapUrl = c.String(),
                    })
                .PrimaryKey(t => t.contactID);
            
        }
    }
}
