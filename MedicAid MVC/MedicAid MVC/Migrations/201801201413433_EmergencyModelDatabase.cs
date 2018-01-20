namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmergencyModelDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmergencyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Location = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmergencyModels");
        }
    }
}
