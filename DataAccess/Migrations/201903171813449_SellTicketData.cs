namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SellTicketData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SellTickets",
                c => new
                    {
                        SellTicketId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellTicketDate = c.DateTime(nullable: false),
                        Client_ClientId = c.Guid(nullable: false),
                        User_UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SellTicketId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Client_ClientId)
                .Index(t => t.User_UserId);
            
            AddColumn("dbo.Products", "SellTicket_SellTicketId", c => c.Guid());
            CreateIndex("dbo.Products", "SellTicket_SellTicketId");
            AddForeignKey("dbo.Products", "SellTicket_SellTicketId", "dbo.SellTickets", "SellTicketId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellTickets", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Products", "SellTicket_SellTicketId", "dbo.SellTickets");
            DropForeignKey("dbo.SellTickets", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.SellTickets", new[] { "User_UserId" });
            DropIndex("dbo.SellTickets", new[] { "Client_ClientId" });
            DropIndex("dbo.Products", new[] { "SellTicket_SellTicketId" });
            DropColumn("dbo.Products", "SellTicket_SellTicketId");
            DropTable("dbo.SellTickets");
        }
    }
}
