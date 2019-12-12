namespace MarketingRecruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Type) VALUES (1,'Marketing')");
            Sql("INSERT INTO MembershipTypes (Id, Type) VALUES (2,'Recruitment')");
            Sql("INSERT INTO MembershipTypes (Id, Type) VALUES (3,'Marketing and Recruitment' )");
        }
        
        public override void Down()
        {
        }
    }
}
