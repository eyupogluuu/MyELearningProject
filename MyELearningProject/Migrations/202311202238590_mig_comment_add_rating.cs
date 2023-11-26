namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_comment_add_rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "rating");
        }
    }
}
