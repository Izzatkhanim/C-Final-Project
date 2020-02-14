namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArciveModelDeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Archives", "OrderId", "dbo.Orders");
            DropIndex("dbo.Archives", new[] { "OrderId" });
            AddColumn("dbo.Orders", "IsDone", c => c.Boolean(nullable: false));
            DropTable("dbo.Archives");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Orders", "IsDone");
            CreateIndex("dbo.Archives", "OrderId");
            AddForeignKey("dbo.Archives", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }
    }
}
