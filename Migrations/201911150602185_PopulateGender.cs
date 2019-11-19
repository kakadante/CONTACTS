namespace CONTACTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGender : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AllGender(Gendername)VALUES('Male')");
            Sql("INSERT INTO AllGender(Gendername)VALUES('Female')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM AllGender WHERE Id IN(1,2)");
        }
    }
}
