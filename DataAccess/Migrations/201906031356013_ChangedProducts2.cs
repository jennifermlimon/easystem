namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedProducts2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "Subcategory_SubcategoryId", "dbo.Subcategories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropIndex("dbo.Products", new[] { "Subcategory_SubcategoryId" });
            RenameColumn(table: "dbo.Products", name: "Subcategory_SubcategoryId", newName: "SubcategoryId");
            AlterColumn("dbo.Products", "SubcategoryId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Products", "SubcategoryId");
            AddForeignKey("dbo.Products", "SubcategoryId", "dbo.Subcategories", "SubcategoryId", cascadeDelete: true);
            DropColumn("dbo.Products", "Amount");
            DropColumn("dbo.Products", "InDate");
            DropColumn("dbo.Products", "OutDate");
            DropColumn("dbo.Products", "Category_CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category_CategoryId", c => c.Guid());
            AddColumn("dbo.Products", "OutDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "InDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Amount", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "SubcategoryId", "dbo.Subcategories");
            DropIndex("dbo.Products", new[] { "SubcategoryId" });
            AlterColumn("dbo.Products", "SubcategoryId", c => c.Guid());
            RenameColumn(table: "dbo.Products", name: "SubcategoryId", newName: "Subcategory_SubcategoryId");
            CreateIndex("dbo.Products", "Subcategory_SubcategoryId");
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Subcategory_SubcategoryId", "dbo.Subcategories", "SubcategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
