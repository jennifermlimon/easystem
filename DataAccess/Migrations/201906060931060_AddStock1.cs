namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStock1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        DateOut = c.DateTime(),
                        SupplierId = c.Guid(nullable: false),
                        ClientId = c.Guid(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId)
                .Index(t => t.ClientId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Stocks", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Stocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stocks", "ClientId", "dbo.Clients");
            DropIndex("dbo.Stocks", new[] { "UserId" });
            DropIndex("dbo.Stocks", new[] { "ClientId" });
            DropIndex("dbo.Stocks", new[] { "SupplierId" });
            DropIndex("dbo.Stocks", new[] { "ProductId" });
            DropTable("dbo.Stocks");
        }
    }
}
