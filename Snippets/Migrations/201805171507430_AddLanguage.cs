namespace Snippets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLanguage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Snippets", "LanguageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Snippets", "LanguageId");
            AddForeignKey("dbo.Snippets", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
            DropColumn("dbo.Snippets", "Language");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Snippets", "Language", c => c.String(nullable: false, maxLength: 200));
            DropForeignKey("dbo.Snippets", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Snippets", new[] { "LanguageId" });
            DropColumn("dbo.Snippets", "LanguageId");
            DropTable("dbo.Languages");
        }
    }
}
