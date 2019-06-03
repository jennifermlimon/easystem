namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubcategoriesData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        SubcategoryId = c.Guid(nullable: false),
                        SubcategoryName = c.String(nullable: false, maxLength: 25),
                        SubcategoryDescription = c.String(),
                        Category_CategoryId = c.Guid(),
                    })
                .PrimaryKey(t => t.SubcategoryId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subcategories", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Subcategories", new[] { "Category_CategoryId" });
            DropTable("dbo.Subcategories");
        }
    }
}
