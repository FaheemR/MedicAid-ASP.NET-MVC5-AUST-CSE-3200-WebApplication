namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmergencyModelInsertData : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO EmergencyModels (Name, Type , Location , Contact) VALUES ('Al Amin- Ambulance Service', 'Ambulance', 'Dhaka', '016XXXXXXXX' )");
            Sql("INSERT INTO EmergencyModels (Name, Type , Location , Contact) VALUES ('Fire Service', 'Fire Service', 'Dhaka', '016XXXXXXXX' )");
            Sql("INSERT INTO EmergencyModels (Name, Type , Location , Contact) VALUES ('Ramna Police Station', 'Police Station', 'Dhaka', '016XXXXXXXX' )");
            Sql("INSERT INTO EmergencyModels (Name, Type , Location , Contact) VALUES ('Red crescent ambulance Ambulance Service', 'Ambulance', 'Dhaka', '016XXXXXXXX' )");
            Sql("INSERT INTO EmergencyModels (Name, Type , Location , Contact) VALUES ('ApanjonAmbulance Service', 'Ambulance', 'Dhaka', '016XXXXXXXX' )");

        }

        public override void Down()
        {
        }
    }
}
