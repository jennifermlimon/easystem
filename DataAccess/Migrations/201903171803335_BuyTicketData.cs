namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuyTicketData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyTickets",
                c => new
                    {
                        BuyTicketId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyTicketDate = c.DateTime(nullable: false),
                        Supplier_SupplierId = c.Guid(nullable: false),
                        User_UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.BuyTicketId)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.User_UserId);
            
            AddColumn("dbo.Products", "BuyTicket_BuyTicketId", c => c.Guid());
            CreateIndex("dbo.Products", "BuyTicket_BuyTicketId");
            AddForeignKey("dbo.Products", "BuyTicket_BuyTicketId", "dbo.BuyTickets", "BuyTicketId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BuyTickets", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.BuyTickets", "Supplier_SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "BuyTicket_BuyTicketId", "dbo.BuyTickets");
            DropIndex("dbo.Products", new[] { "BuyTicket_BuyTicketId" });
            DropIndex("dbo.BuyTickets", new[] { "User_UserId" });
            DropIndex("dbo.BuyTickets", new[] { "Supplier_SupplierId" });
            DropColumn("dbo.Products", "BuyTicket_BuyTicketId");
            DropTable("dbo.BuyTickets");
        }
    }
}
