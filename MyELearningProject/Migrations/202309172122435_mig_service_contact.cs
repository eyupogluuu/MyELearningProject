namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_service_contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        aboutID = c.Int(nullable: false, identity: true),
                        aboutDescreption = c.String(),
                        aboutImage = c.String(),
                    })
                .PrimaryKey(t => t.aboutID);
            
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
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        serviceID = c.Int(nullable: false, identity: true),
                        servicetittle = c.String(),
                        servicedescreption = c.String(),
                        serviceimage = c.String(),
                    })
                .PrimaryKey(t => t.serviceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.Contacts");
            DropTable("dbo.Abouts");
        }
    }
}
