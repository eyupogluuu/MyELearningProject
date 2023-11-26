namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_inst_tittle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "tittle", c => c.String());
            AddColumn("dbo.Instructors", "coverimage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "coverimage");
            DropColumn("dbo.Instructors", "tittle");
        }
    }
}
