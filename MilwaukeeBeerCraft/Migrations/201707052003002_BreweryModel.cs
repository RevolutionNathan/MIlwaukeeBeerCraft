namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BreweryModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MilwaukeeBreweries", "Lat", c => c.Double(nullable: false));
            AlterColumn("dbo.MilwaukeeBreweries", "Long", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MilwaukeeBreweries", "Long", c => c.Int(nullable: false));
            AlterColumn("dbo.MilwaukeeBreweries", "Lat", c => c.Int(nullable: false));
        }
    }
}
