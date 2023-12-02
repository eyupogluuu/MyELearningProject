namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_adminmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "adminMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "adminMail");
        }
    }
}
