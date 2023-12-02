namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_ins_mail_password : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "mail", c => c.String());
            AddColumn("dbo.Instructors", "password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "password");
            DropColumn("dbo.Instructors", "mail");
        }
    }
}
