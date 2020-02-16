namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneAddedToClientModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Phone", c => c.Int(nullable: false));
        }
    }
}
