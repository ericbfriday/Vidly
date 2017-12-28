namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeNameUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.Customers", "MembershipTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
