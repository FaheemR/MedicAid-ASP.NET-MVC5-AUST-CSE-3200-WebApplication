namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorModelDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoctorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Specialist = c.String(),
                        HospitalName = c.String(),
                        Contact = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DoctorModels");
        }
    }
}
