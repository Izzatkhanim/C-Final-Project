namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrosFixed3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReturnDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturnDate", c => c.DateTime(nullable: false));
        }
    }
}
