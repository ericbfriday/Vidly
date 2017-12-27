namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeNameData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Pay As You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Yearly' WHERE DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
