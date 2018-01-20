namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HospitalModelInsertData : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Labaid Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Square Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Apolo Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Medi Nova Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Central Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
            Sql("INSERT INTO HospitalModels (Name, Location , ClosingDay , Contact) VALUES ('Dhaka Medical Hospital', 'Dhaka', 'Friday', '016XXXXXXXX' )");
              
        }
        
        public override void Down()
        {
        }
    }
}
