namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSell : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SellTickets", name: "Client_ClientId", newName: "ClientId");
            RenameColumn(table: "dbo.SellTickets", name: "User_UserId", newName: "UserId");
            RenameIndex(table: "dbo.SellTickets", name: "IX_User_UserId", newName: "IX_UserId");
            RenameIndex(table: "dbo.SellTickets", name: "IX_Client_ClientId", newName: "IX_ClientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SellTickets", name: "IX_ClientId", newName: "IX_Client_ClientId");
            RenameIndex(table: "dbo.SellTickets", name: "IX_UserId", newName: "IX_User_UserId");
            RenameColumn(table: "dbo.SellTickets", name: "UserId", newName: "User_UserId");
            RenameColumn(table: "dbo.SellTickets", name: "ClientId", newName: "Client_ClientId");
        }
    }
}
