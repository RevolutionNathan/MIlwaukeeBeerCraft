namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnHeaders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilwaukeeBreweries", "lng", c => c.Double(nullable: false));
            DropColumn("dbo.MilwaukeeBreweries", "Long");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MilwaukeeBreweries", "Long", c => c.Double(nullable: false));
            DropColumn("dbo.MilwaukeeBreweries", "lng");
        }
    }
}
