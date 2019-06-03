namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedProducts1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
