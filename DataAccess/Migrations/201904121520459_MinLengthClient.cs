namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinLengthClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "ClientSurname1", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Clients", "ClientSurname2", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "ClientSurname2", c => c.String(maxLength: 13));
            AlterColumn("dbo.Clients", "ClientSurname1", c => c.String(nullable: false, maxLength: 13));
        }
    }
}
