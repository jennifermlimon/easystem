namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 25),
                        ProductDescription = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InDate = c.DateTime(nullable: false),
                        OutDate = c.DateTime(nullable: false),
                        Category_CategoryId = c.Guid(),
                        Subcategory_SubcategoryId = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .ForeignKey("dbo.Subcategories", t => t.Subcategory_SubcategoryId)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Subcategory_SubcategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Subcategory_SubcategoryId", "dbo.Subcategories");
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Subcategory_SubcategoryId" });
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropTable("dbo.Products");
        }
    }
}
