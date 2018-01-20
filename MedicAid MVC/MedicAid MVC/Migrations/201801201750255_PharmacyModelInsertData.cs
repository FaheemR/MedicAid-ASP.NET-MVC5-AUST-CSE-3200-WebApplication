namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PharmacyModelInsertData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('A Am Store', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('Day Night Pharmacy', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('Lazz Pharma', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('Jonoprio', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('Prescription Aid', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO PharmacyModels (Name, Location , ClosingDay , Contact) VALUES ('Health & Hope Pharma', 'Khulna', 'Friday', '016XXXXXXXX' )");

        }

        public override void Down()
        {
        }
    }
}
