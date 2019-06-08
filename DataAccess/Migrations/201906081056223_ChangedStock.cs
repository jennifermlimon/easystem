namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedStock : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Stocks", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Stocks", "UserId", "dbo.Users");
            DropIndex("dbo.Stocks", new[] { "SupplierId" });
            DropIndex("dbo.Stocks", new[] { "ClientId" });
            DropIndex("dbo.Stocks", new[] { "UserId" });
            AddColumn("dbo.Stocks", "BuyTicketId", c => c.Guid(nullable: false));
            AddColumn("dbo.Stocks", "SellTicketId", c => c.Guid());
            CreateIndex("dbo.Stocks", "BuyTicketId");
            CreateIndex("dbo.Stocks", "SellTicketId");
            AddForeignKey("dbo.Stocks", "BuyTicketId", "dbo.BuyTickets", "BuyTicketId", cascadeDelete: true);
            AddForeignKey("dbo.Stocks", "SellTicketId", "dbo.SellTickets", "SellTicketId");
            DropColumn("dbo.Stocks", "SupplierId");
            DropColumn("dbo.Stocks", "ClientId");
            DropColumn("dbo.Stocks", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stocks", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Stocks", "ClientId", c => c.Guid());
            AddColumn("dbo.Stocks", "SupplierId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Stocks", "SellTicketId", "dbo.SellTickets");
            DropForeignKey("dbo.Stocks", "BuyTicketId", "dbo.BuyTickets");
            DropIndex("dbo.Stocks", new[] { "SellTicketId" });
            DropIndex("dbo.Stocks", new[] { "BuyTicketId" });
            DropColumn("dbo.Stocks", "SellTicketId");
            DropColumn("dbo.Stocks", "BuyTicketId");
            CreateIndex("dbo.Stocks", "UserId");
            CreateIndex("dbo.Stocks", "ClientId");
            CreateIndex("dbo.Stocks", "SupplierId");
            AddForeignKey("dbo.Stocks", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Stocks", "SupplierId", "dbo.Suppliers", "SupplierId", cascadeDelete: true);
            AddForeignKey("dbo.Stocks", "ClientId", "dbo.Clients", "ClientId");
        }
    }
}
