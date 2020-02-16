namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceDatatypeChangedToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
