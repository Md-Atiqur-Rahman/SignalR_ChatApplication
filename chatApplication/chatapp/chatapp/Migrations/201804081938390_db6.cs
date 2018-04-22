namespace chatapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatUsers", "Connected", c => c.Boolean(nullable: false));
            DropColumn("dbo.ChatUsers", "ConnectionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChatUsers", "ConnectionId", c => c.String());
            DropColumn("dbo.ChatUsers", "Connected");
        }
    }
}
