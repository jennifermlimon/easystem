namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCashier : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cashiers",
                c => new
                    {
                        CashierId = c.Guid(nullable: false),
                        OpenDateTime = c.DateTime(nullable: false),
                        CloseDateTime = c.DateTime(nullable: false),
                        Close = c.Boolean(nullable: false),
                        Amount = c.Double(nullable: false),
                        ToBank = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CashierId);
            
            AddColumn("dbo.SellTickets", "CashierId", c => c.Guid());
            CreateIndex("dbo.SellTickets", "CashierId");
            AddForeignKey("dbo.SellTickets", "CashierId", "dbo.Cashiers", "CashierId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellTickets", "CashierId", "dbo.Cashiers");
            DropIndex("dbo.SellTickets", new[] { "CashierId" });
            DropColumn("dbo.SellTickets", "CashierId");
            DropTable("dbo.Cashiers");
        }
    }
}
