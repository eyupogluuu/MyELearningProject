namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_contact_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "office", c => c.String());
            AddColumn("dbo.Contacts", "mobile", c => c.String());
            AddColumn("dbo.Contacts", "email", c => c.String());
            AddColumn("dbo.Contacts", "mapUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "mapUrl");
            DropColumn("dbo.Contacts", "email");
            DropColumn("dbo.Contacts", "mobile");
            DropColumn("dbo.Contacts", "office");
        }
    }
}
