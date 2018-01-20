namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PharmacyModelDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PharmacyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        ClosingDay = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PharmacyModels");
        }
    }
}
