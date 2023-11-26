namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "categoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "categoryID");
            AddForeignKey("dbo.Courses", "categoryID", "dbo.Categories", "categoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "categoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "categoryID" });
            DropColumn("dbo.Courses", "categoryID");
        }
    }
}
