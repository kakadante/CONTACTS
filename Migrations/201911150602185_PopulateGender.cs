namespace CONTACTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGender : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Gender(Gendername)VALUES('Male')");
            Sql("INSERT INTO Gender(Gendername)VALUES('Female')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Gender WHERE Id IN(1,2)");
        }
    }
}
