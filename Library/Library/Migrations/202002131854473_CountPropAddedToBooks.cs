namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountPropAddedToBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Count");
        }
    }
}
