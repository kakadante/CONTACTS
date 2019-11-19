namespace CONTACTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Allcontacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone_Number = c.String(),
                        Email = c.String(),
                        GenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gendername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Allcontacts", "GenderId", "dbo.Genders");
            DropIndex("dbo.Allcontacts", new[] { "GenderId" });
            DropTable("dbo.Genders");
            DropTable("dbo.Allcontacts");
        }
    }
}
