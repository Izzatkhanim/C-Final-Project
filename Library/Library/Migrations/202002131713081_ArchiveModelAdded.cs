namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArchiveModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Archives", "OrderId", "dbo.Orders");
            DropIndex("dbo.Archives", new[] { "OrderId" });
            DropTable("dbo.Archives");
        }
    }
}
