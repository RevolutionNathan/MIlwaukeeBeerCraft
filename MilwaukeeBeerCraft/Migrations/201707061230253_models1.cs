namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MilwaukeeBreweries", "lat");
            DropColumn("dbo.MilwaukeeBreweries", "lng");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MilwaukeeBreweries", "lng", c => c.Double(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "lat", c => c.Double(nullable: false));
        }
    }
}
