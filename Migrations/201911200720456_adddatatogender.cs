namespace CONTACTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatatogender : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Genders", newName: "AllGenders");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AllGenders", newName: "Genders");
        }
    }
}
