namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSubcategories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subcategories", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Subcategories", new[] { "Category_CategoryId" });
            RenameColumn(table: "dbo.Subcategories", name: "Category_CategoryId", newName: "CategoryId");
            AlterColumn("dbo.Subcategories", "CategoryId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Subcategories", "CategoryId");
            AddForeignKey("dbo.Subcategories", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subcategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Subcategories", new[] { "CategoryId" });
            AlterColumn("dbo.Subcategories", "CategoryId", c => c.Guid());
            RenameColumn(table: "dbo.Subcategories", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Subcategories", "Category_CategoryId");
            AddForeignKey("dbo.Subcategories", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
