namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Guid(nullable: false),
                        ClientName = c.String(nullable: false, maxLength: 25),
                        ClientSurname1 = c.String(nullable: false, maxLength: 13),
                        ClientSurname2 = c.String(maxLength: 13),
                        ClientDateOfBirth = c.DateTime(nullable: false),
                        CLientTelephone = c.String(nullable: false, maxLength: 13),
                        ClientNif = c.String(nullable: false, maxLength: 9),
                        ClientEmail = c.String(nullable: false, maxLength: 50),
                        ClientAdress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
