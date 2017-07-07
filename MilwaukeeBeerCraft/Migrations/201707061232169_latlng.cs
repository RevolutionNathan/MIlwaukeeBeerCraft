namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latlng : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilwaukeeBreweries", "lat", c => c.Double(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "lng", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MilwaukeeBreweries", "lng");
            DropColumn("dbo.MilwaukeeBreweries", "lat");
        }
    }
}
