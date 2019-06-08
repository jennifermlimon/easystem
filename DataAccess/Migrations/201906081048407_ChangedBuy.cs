namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBuy : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BuyTickets", name: "Supplier_SupplierId", newName: "SupplierId");
            RenameColumn(table: "dbo.BuyTickets", name: "User_UserId", newName: "UserId");
            RenameIndex(table: "dbo.BuyTickets", name: "IX_User_UserId", newName: "IX_UserId");
            RenameIndex(table: "dbo.BuyTickets", name: "IX_Supplier_SupplierId", newName: "IX_SupplierId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.BuyTickets", name: "IX_SupplierId", newName: "IX_Supplier_SupplierId");
            RenameIndex(table: "dbo.BuyTickets", name: "IX_UserId", newName: "IX_User_UserId");
            RenameColumn(table: "dbo.BuyTickets", name: "UserId", newName: "User_UserId");
            RenameColumn(table: "dbo.BuyTickets", name: "SupplierId", newName: "Supplier_SupplierId");
        }
    }
}
