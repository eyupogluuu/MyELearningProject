namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_about_tittle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "aboutTittle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "aboutTittle");
        }
    }
}
