namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneAddedToClientModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Phone");
        }
    }
}
