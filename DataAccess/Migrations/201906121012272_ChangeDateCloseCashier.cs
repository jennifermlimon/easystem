namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateCloseCashier : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cashiers", "CloseDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cashiers", "CloseDateTime", c => c.DateTime(nullable: false));
        }
    }
}
