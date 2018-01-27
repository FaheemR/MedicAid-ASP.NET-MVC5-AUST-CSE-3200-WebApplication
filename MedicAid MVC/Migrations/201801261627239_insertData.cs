namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PharmacyModels", "ClosingDay", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PharmacyModels", "ClosingDay", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
