namespace Snippets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategorySnippets",
                c => new
                    {
                        Category_Id = c.Int(nullable: false),
                        Snippet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Snippet_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Snippets", t => t.Snippet_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Snippet_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategorySnippets", "Snippet_Id", "dbo.Snippets");
            DropForeignKey("dbo.CategorySnippets", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CategorySnippets", new[] { "Snippet_Id" });
            DropIndex("dbo.CategorySnippets", new[] { "Category_Id" });
            DropTable("dbo.CategorySnippets");
            DropTable("dbo.Categories");
        }
    }
}
