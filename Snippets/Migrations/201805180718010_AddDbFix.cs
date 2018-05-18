namespace Snippets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDbFix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategorySnippets", newName: "SnippetCategories");
            DropPrimaryKey("dbo.SnippetCategories");
            AddPrimaryKey("dbo.SnippetCategories", new[] { "Snippet_Id", "Category_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SnippetCategories");
            AddPrimaryKey("dbo.SnippetCategories", new[] { "Category_Id", "Snippet_Id" });
            RenameTable(name: "dbo.SnippetCategories", newName: "CategorySnippets");
        }
    }
}
