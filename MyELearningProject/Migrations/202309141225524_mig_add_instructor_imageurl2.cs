namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_instructor_imageurl2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "imageUrl", c => c.String());
            DropColumn("dbo.Instructors", "ımageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructors", "ımageUrl", c => c.String());
            DropColumn("dbo.Instructors", "imageUrl");
        }
    }
}
