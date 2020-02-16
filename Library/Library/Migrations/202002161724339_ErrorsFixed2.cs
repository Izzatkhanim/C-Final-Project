namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorsFixed2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReturnPrice", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturnPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
