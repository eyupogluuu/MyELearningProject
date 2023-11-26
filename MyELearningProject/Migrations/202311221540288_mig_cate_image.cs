namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_cate_image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "categoryimage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "categoryimage");
        }
    }
}
