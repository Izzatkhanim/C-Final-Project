namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnPriceAndReturnDateIsAddedToOrderModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "ReturnPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ReturnPrice");
            DropColumn("dbo.Orders", "ReturnDate");
        }
    }
}
