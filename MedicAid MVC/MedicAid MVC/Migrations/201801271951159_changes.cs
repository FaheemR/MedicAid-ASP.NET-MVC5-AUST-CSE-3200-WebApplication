namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmergencyModels", "Type", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.EmergencyModels", "Location", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PharmacyModels", "Location", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PharmacyModels", "Location", c => c.String());
            AlterColumn("dbo.EmergencyModels", "Location", c => c.String());
            AlterColumn("dbo.EmergencyModels", "Type", c => c.String());
        }
    }
}
