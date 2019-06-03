namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Guid(nullable: false),
                        SupplierName = c.String(nullable: false, maxLength: 25),
                        SupplierTelephone = c.String(nullable: false, maxLength: 13),
                        SupplierCif = c.String(nullable: false, maxLength: 9),
                        SupplierEmail = c.String(nullable: false, maxLength: 50),
                        SupplierAdress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
        }
    }
}
