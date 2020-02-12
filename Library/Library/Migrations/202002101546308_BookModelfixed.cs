namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModelfixed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Author = c.String(nullable: false, maxLength: 50),
                        Genre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "Book_Id", c => c.Int());
            CreateIndex("dbo.Clients", "Book_Id");
            AddForeignKey("dbo.Clients", "Book_Id", "dbo.Books", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Book_Id", "dbo.Books");
            DropIndex("dbo.Clients", new[] { "Book_Id" });
            DropColumn("dbo.Clients", "Book_Id");
            DropTable("dbo.Books");
        }
    }
}
