namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mid_add_contact_datetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
