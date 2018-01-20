namespace MedicAid_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorModelInsertData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Sayef', 'Allergist', 'Labaid', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Shaafi', 'Allergist', 'Square', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Eva', 'Allergist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Rumu', 'Cardiologist', 'Apolo', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Arefeen', 'Cardiac electrophysiologist', 'Labaid', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Asif', 'Cardiologist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Imtiaz', 'Cardiovascular surgeon', 'Apolo', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Reyadh', 'Cardiologist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Sayef', 'Cardiovascular surgeon', 'Square', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Sayef', 'Anesthesiologist', 'Labaid', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Shaafi', 'Allergist', 'Square', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Eva', 'Anesthesiologist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Rumu', 'Cardiologist', 'Apolo', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Arefeen', 'Cardiac electrophysiologist', 'Labaid', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Asif', 'Anesthesiologist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Imtiaz', 'Cardiovascular surgeon', 'Apolo', '016XXXXXXXX' , 1)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Reyadh', 'Anesthesiologist', 'Labaid', '016XXXXXXXX' , 2)");
            Sql("INSERT INTO DoctorModels (Name, Specialist, HospitalName, Contact, IsAvailable) VALUES ('Sayef', 'Cardiovascular surgeon', 'Square', '016XXXXXXXX' , 1)");

        }

        public override void Down()
        {
        }
    }
}
