namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_adr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adrs",
                c => new
                    {
                        adrID = c.Int(nullable: false, identity: true),
                        adrtittle = c.String(),
                        tel = c.String(),
                        email = c.String(),
                        locationlink = c.String(),
                    })
                .PrimaryKey(t => t.adrID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adrs");
        }
    }
}
