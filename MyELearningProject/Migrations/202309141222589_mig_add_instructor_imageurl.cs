namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_instructor_imageurl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "ımageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "ımageUrl");
        }
    }
}
