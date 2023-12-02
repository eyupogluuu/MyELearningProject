namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        adminID = c.Int(nullable: false, identity: true),
                        kullaniciAdi = c.String(),
                        sifre = c.String(),
                    })
                .PrimaryKey(t => t.adminID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
