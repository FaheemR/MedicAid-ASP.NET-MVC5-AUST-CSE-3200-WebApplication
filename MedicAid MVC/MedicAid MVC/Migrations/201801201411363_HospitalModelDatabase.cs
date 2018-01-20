namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HospitalModelDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HospitalModels",
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
            DropTable("dbo.HospitalModels");
        }
    }
}
